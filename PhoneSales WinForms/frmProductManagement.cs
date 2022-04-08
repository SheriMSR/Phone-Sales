using Business_Object.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSales_WinForms
{
    public partial class frmProductManagement : Form
    {
        public frmProductManagement()
        {
            InitializeComponent();
        }

        IProductRepository productRepository = new ProductRepository();
        BindingSource source;


        public void ClearText()
        {
            textID.Text = "";
            textName.Text = "";
            textBrand.Text = "";
            textPrice.Text = "";
            textQuantity.Text = "";
        }

        public void LoadProductList()
        {
            try
            {
                var pros = productRepository.GetProducts();
                source = new BindingSource();
                source.DataSource = pros;

                textID.DataBindings.Clear();
                textName.DataBindings.Clear();
                textBrand.DataBindings.Clear();
                textPrice.DataBindings.Clear();
                textQuantity.DataBindings.Clear();

                textID.DataBindings.Add("Text", source, "ProductID");
                textName.DataBindings.Add("Text", source, "ProductName");
                textBrand.DataBindings.Add("Text", source, "ProductBrand");
                textPrice.DataBindings.Add("Text", source, "ProductPrice");
                textQuantity.DataBindings.Add("Text", source, "ProductQuantity");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                if (pros.Count() == 0)
                {
                    ClearText();
                    Delete.Enabled = false;
                }
                else
                {
                    Delete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List");
            }
        }

        private Product GetProductObject()
        {
            Product pro = null;
            try
            {
                pro = new Product
                {
                    ProductId = textID.Text,
                    ProductName = textName.Text,
                    ProductBrand = textBrand.Text,
                    ProductPrice = float.Parse(textPrice.Text),
                    ProductQuantity = int.Parse(textQuantity.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return pro;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Add Product",
                InsertOrUpdate = false
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }
        private void DgvListView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                productInfo = GetProductObject()
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                btnLoad_Click(sender, e);
                source.Position = source.Count - 1;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Confirm Delete ?", "Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.OK)
                {
                    var pro = new Product
                    {
                        ProductId = textID.Text
                    };
                    productRepository.RemoveProduct(pro);
                    LoadProductList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            Delete.Enabled = false;
            dataGridView1.CellDoubleClick += DgvListView_CellDoubleClick;

        }
    }
        }
