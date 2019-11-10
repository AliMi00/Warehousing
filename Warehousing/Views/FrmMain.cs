using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehousing.Models;
using Warehousing.Services;


namespace Warehousing.Views
{
    public partial class FrmMain : Form
    {
        private List<Product> products = new List<Product>();
        private List<SoldProduct> soldProducts = new List<SoldProduct>();
        private int DeleteId = 0;

        public FrmMain()
        {
            InitializeComponent();

        }
        //update ProductsList and SoldProduct
        private async Task UpdateProductListAndSold()
        {
            
            products = await GetAndSetData.GetProductsAsync();
            soldProducts = await GetAndSetData.GetSoldProductsAsync();
            dgvSellProduct.DataSource = products;
            dgvAddProductList.DataSource = products;

        }
        //Customize 
        private void DgvCustomize()
        {
            dgvSellProduct.Columns[0].Visible = false;
            dgvSellProduct.Columns[1].HeaderText = "کد کالا ";
            dgvSellProduct.Columns[2].HeaderText = "نام کالا";
            dgvSellProduct.Columns[3].HeaderText = "تعداد";
            dgvSellProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSellProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSellProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvAddProductList.Columns[0].Visible = false;
            dgvAddProductList.Columns[1].HeaderText = "کد کالا ";
            dgvAddProductList.Columns[2].HeaderText = "نام کالا";
            dgvAddProductList.Columns[3].HeaderText = "تعداد";
            dgvAddProductList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAddProductList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAddProductList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvStoreStatus.Columns[0].Visible = false;
            dgvStoreStatus.Columns[1].HeaderText = "کد کالا ";
            dgvStoreStatus.Columns[2].HeaderText = "نام کالا";
            dgvStoreStatus.Columns[3].HeaderText = "تعداد موجود";
            dgvStoreStatus.Columns[4].HeaderText = "تعداد فروش رفته";
            dgvStoreStatus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStoreStatus.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStoreStatus.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStoreStatus.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await GetStatus();
            await UpdateProductListAndSold();
            DgvCustomize();
        }

        //AddProduct
        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Code = txtAddProductCode.Text;
            product.Name = txtAddProductName.Text;
            product.Quantity =Convert.ToInt32( txtAddProductQuantity.Text);
            try
            {
                await GetAndSetData.SetProduct(product);
                await UpdateProductListAndSold();
                MessageBox.Show("با موفقیت ثبت شد ",
                                "موفق",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n",
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private async void txtAddSearchCode_TextChanged(object sender, EventArgs e)
        {
            List<Product> ListProducts = products;
            try
            {
                if (txtAddSearchCode.Text.Equals(""))
                {
                    await UpdateProductListAndSold();
                }
                
                ListProducts = products.Where(x => x.Code.StartsWith(txtAddSearchCode.Text.ToString().Trim())).ToList<Product>();
                dgvAddProductList.DataSource = ListProducts;

            }
            catch (Exception ex)
            {

            }
        }

        private async void txtAddSearchName_TextChanged(object sender, EventArgs e)
        {
            List<Product> ListProducts = products;
            try
            {
                if (txtAddSearchName.Text.Equals(""))
                {
                    await UpdateProductListAndSold();
                }

                ListProducts = products.Where(x => x.Name.StartsWith(txtAddSearchName.Text.ToString().Trim())).ToList<Product>();
                dgvAddProductList.DataSource = ListProducts;

            }
            catch (Exception ex)
            {

            }
        }
        //btn Delete Product
        private async void btnAddUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = DeleteId;
            try
            {
                if (soldProducts.Where(x => x.ProductId.Equals(product.Id)).Any())
                    throw new Exception("محصولی که مصرف شده است امکان حذف ندارد ");

                await GetAndSetData.DeleteProduct(product);
                await UpdateProductListAndSold();
                MessageBox.Show("با موفقیت ثبت شد ",
                                "موفق",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n",
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvAddProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvAddProductList.SelectedRows.Count == 1)
            {
                DeleteId = Convert.ToInt32(dgvAddProductList[0, dgvAddProductList.SelectedRows[0].Index].Value);
            }


        }


//Edit Product Quantity
        private async void btnChangeIncrease_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Code = txtSellCode.Text;
            product.Quantity = Convert.ToInt32(txtSellQuantity.Text);
            try
            {
                await GetAndSetData.IncreaseProductQuantity(product);
                MessageBox.Show("با موفقیت ثبت شد ",
                                        "موفق",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n",
                                    "خطا",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private async void btnChangeDecrease_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Code = txtSellCode.Text;
            product.Quantity = Convert.ToInt32(txtSellQuantity.Text);
            try
            {
                await GetAndSetData.DecreaseProductQuantity(product);
                MessageBox.Show("با موفقیت ثبت شد ",
                                        "موفق",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n",
                                    "خطا",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }
//Status
        private async Task GetStatus()
        {
            List<WareHousStatus> wareHousStatuses = new List<WareHousStatus>();
            await UpdateProductListAndSold();
            foreach(Product p in products)
            {
                WareHousStatus wareHousStatus = new WareHousStatus();
                Chart.Series[0].Points.AddXY(p.Name, p.Quantity);
                int soldProduct = soldProducts.Where(x => x.ProductId.Equals(p.Id)).Sum(x => x.Quantity);
                Chart.Series[1].Points.AddXY(p.Name, soldProduct);
                wareHousStatus.Id = p.Id;
                wareHousStatus.Code = p.Code;
                wareHousStatus.Name = p.Name;
                wareHousStatus.QuantityExist = p.Quantity;
                wareHousStatus.QuantitySold = soldProduct;
                wareHousStatuses.Add(wareHousStatus);
                
            }
            dgvStoreStatus.DataSource = wareHousStatuses;


        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in Chart.Series)
            {
                series.Points.Clear();
            }
            await GetStatus();
            await UpdateProductListAndSold();

        }
    }
}
