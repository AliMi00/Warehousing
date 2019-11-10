using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Warehousing.Models;


namespace Warehousing.Services
{
    public static class GetAndSetData
    {
        //listToTable
        public static DataTable ListToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        // function that creates a list of an object from the given data table
        public static List<T> DataTableToList<T>(DataTable tbl) where T : new()
        {
            // define return list
            List<T> lst = new List<T>();

            // go through each row
            foreach (DataRow r in tbl.Rows)
            {
                // add to the list
                lst.Add(CreateItemFromRow<T>(r));
            }

            // return the list
            return lst;
        }
        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {
            // create a new object
            T item = new T();

            // set the item
            SetItemFromRow(item, row);

            // return 
            return item;
        }
        public static void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            // go through each column
            foreach (DataColumn c in row.Table.Columns)
            {
                // find the property for the column
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                // if exists, set the value
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }
        //get product
        public static async Task<List<Product>> GetProductsAsync()
        {
            List<Product> products = new List<Product>();
            DataTable dtProduct = await DataAccessAsync.ExecSPAsync("GetProducts");
            //check info
            return DataTableToList<Product>(dtProduct);
        }
        // Get Sold product 
        public static async Task<List<SoldProduct>> GetSoldProductsAsync()
        {
            List<SoldProduct> soldProducts = new List<SoldProduct>();
            DataTable dtProduct = await DataAccessAsync.ExecSPAsync("GetSoldProducts");
            //check info
            return DataTableToList<SoldProduct>(dtProduct);
        }
        //set product and check it's new
        public static async Task SetProduct(Product product)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("Code", product.Code));
            sqlParameters.Add(new SqlParameter("Name", product.Name));
            sqlParameters.Add(new SqlParameter("Quantity", product.Quantity));
            try
            {
                List<Product> products = await GetProductsAsync();
                if (!products.Where(x => x.Code == product.Code).Any())
                    await DataAccessAsync.ExecSPAsync("SetProduct", sqlParameters);
                else
                    throw new Exception("محصول با این کد موجود است");
            }
            catch (Exception ex)
            {
                throw new Exception("مشکل در ثبت محصول " + ex.Message);
            }

        }
        //Delete product 
        public static async Task DeleteProduct(Product product)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("Id", product.Id));

            try
            {
                List<Product> products = await GetProductsAsync();
                if (products.Where(x => x.Id == product.Id).Any())
                    await DataAccessAsync.ExecSPAsync("DeleteProduct", sqlParameters);
                else
                    throw new Exception("محصول موجود نیست");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //decrease product quantity and add sold product 
        public static async Task DecreaseProductQuantity(Product product)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            try
            {
                List<Product> products = await GetProductsAsync();
                if (products.Where(x => x.Code.Equals( product.Code)).Any() &&
                    products.Where(x => x.Code.Equals(product.Code)).FirstOrDefault<Product>().Quantity >= product.Quantity)
                {
                    int quantity = products.Where(x => x.Code.Equals(product.Code)).FirstOrDefault<Product>().Quantity - product.Quantity;
                    int Id = products.Where(x => x.Code.Equals(product.Code)).FirstOrDefault<Product>().Id;

                    sqlParameters.Add(new SqlParameter("Quantity", quantity));
                    sqlParameters.Add(new SqlParameter("Id", Id));
                    await DataAccessAsync.ExecSPAsync("DecreaseQuantityProduct", sqlParameters);
                    
                }
                else
                    throw new Exception("محصول به تعداد کافی موجود نیست");
            }
            catch (Exception ex)
            {
                throw new Exception(" مشکل در ثبت محصول " + "/n" + ex.Message);
            }
        }
        //Increase product quantity
        public static async Task IncreaseProductQuantity(Product product)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            try
            {
                List<Product> products = await GetProductsAsync();
                if (products.Where(x => x.Code == product.Code).Any())
                {
                    int quantity = products.Single<Product>(x => x.Code.Equals(product.Code)).Quantity + product.Quantity;
                    int Id = products.Single<Product>(x => x.Code.Equals(product.Code)).Id;
                    sqlParameters.Add(new SqlParameter("Id", Id));
                    sqlParameters.Add(new SqlParameter("Quantity", quantity));
                    await DataAccessAsync.ExecSPAsync("IncreaseQuantityProduct", sqlParameters);
                }
                else
                    throw new Exception("محصول به تعداد کافی موجود نیست");
            }
            catch (Exception ex)
            {
                throw new Exception(" مشکل در ثبت محصول " + "/n" + ex.Message);
            }
        }


    }
}
