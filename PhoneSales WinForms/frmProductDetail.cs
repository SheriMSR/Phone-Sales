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
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        IProductRepository productRepository = new ProductRepository();
        public bool InsertOrUpdate { get; set; }
        public Product productInfo { get; set; }


        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text)
                    || String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("All information must be filled !", "Error");
                }
                else
                {
                    var pro = new Product
                    {
                        ProductId = textBox1.Text,
                        ProductName = textBox2.Text,
                        ProductBrand = comboBox1.Text,
                        ProductPrice = float.Parse(textBox3.Text),
                        ProductQuantity = int.Parse(textBox4.Text)
                    };
                    if (InsertOrUpdate == false)
                    {
                        productRepository.AddProduct(pro);
                    }
                    else
                    {
                        productRepository.UpdateProduct(pro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update a product");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                textBox1.Text = productInfo.ProductId.ToString();
                textBox1.Enabled = false;
                textBox2.Text = productInfo.ProductName.ToString();
                comboBox1.Text = productInfo.ProductBrand.ToString();
                textBox3.Text = productInfo.ProductPrice.ToString();
                textBox4.Text = productInfo.ProductQuantity.ToString();
            }
        }
    }
}
