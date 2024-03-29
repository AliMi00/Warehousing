﻿using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
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
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output =await cnn.QueryAsync<Product>("Select * From Products", new DynamicParameters());
                return output.ToList();
            }

        }
        // Get Sold product 
        public static async Task<List<SoldProduct>> GetSoldProductsAsync()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<SoldProduct>("Select * From SoldProduct", new DynamicParameters());
                return output.ToList();
            }
        }
        //set product and check it's new
        public static async Task SetProduct(Product product)
        {
            try
            {
                List<Product> products = await GetProductsAsync();
                if (!products.Where(x => x.Code == product.Code).Any())
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        await cnn.ExecuteAsync("insert into Products(Code,Name,Quantity) values(@Code, @Name, @Quantity)", new DynamicParameters(product));

                    }
                }
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
            try
            {
                List<Product> products = await GetProductsAsync();
                if (products.Where(x => x.Id == product.Id).Any())
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        await cnn.ExecuteAsync("	delete Products where Id = @Id", new DynamicParameters(product));

                    }
                }    
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
            try
            {
                List<Product> products = await GetProductsAsync();
                if (products.Where(x => x.Code.Equals( product.Code)).Any() &&
                    products.Where(x => x.Code.Equals(product.Code)).FirstOrDefault<Product>().Quantity >= product.Quantity)
                {
                    int quantity = products.Where(x => x.Code.Equals(product.Code)).FirstOrDefault<Product>().Quantity - product.Quantity;
                    int Id = products.Where(x => x.Code.Equals(product.Code)).FirstOrDefault<Product>().Id;

                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("Quantity", quantity);
                    parameters.Add("Id", Id);
                    parameters.Add("QuantitySold",product.Quantity);
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        await cnn.ExecuteAsync(" BEGIN TRANSACTION; Update Products set  Quantity = @Quantity where Id = @Id ;" +
                            " insert into SoldProduct(ProductId, Quantity) values(@Id, @QuantitySold); commit;", parameters) ;
                    }

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
            try
            {
                List<Product> products = await GetProductsAsync();
                if (products.Where(x => x.Code == product.Code).Any())
                {
                    int quantity = products.Single<Product>(x => x.Code.Equals(product.Code)).Quantity + product.Quantity;
                    int Id = products.Single<Product>(x => x.Code.Equals(product.Code)).Id;

                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("Quantity", quantity);
                    parameters.Add("Id", Id);
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        await cnn.ExecuteAsync("Update Products set  Quantity = @Quantity where Id = @Id", parameters);
                    }
                }
                else
                    throw new Exception("محصول به تعداد کافی موجود نیست");
            }
            catch (Exception ex)
            {
                throw new Exception(" مشکل در ثبت محصول " + "/n" + ex.Message);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
