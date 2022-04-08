using Business_Object.Models;
using Data_Access.Repository;
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
    public partial class frmOrderDetail : Form
    {
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderDetail OrderInfor { get; set; }
        public int OrderId { get; set; }
        IProductRepository IProductRepository = new ProductRepository();
        BindingSource source;
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDDetails_Load(object sender, EventArgs e)
        {

            txtProductID.Enabled = !InsertOrUpdate;
            txtOrderId.Enabled = false;
            txtOrderId.Text = OrderId.ToString();

            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtProductID.Text = OrderInfor.ProductId.ToString();
                txtQuantity.Text = OrderInfor.Quantity.ToString();
                txtDiscount.Text = OrderInfor.Discount.ToString();
                txtTotalPrice.Text = OrderInfor.TotalPrice.ToString();

            }
        }

        public void LoadMemberList()
        {
            var members = IProductRepository.GetProducts();

            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.ProductName);
                txtProductID.DataBindings.Clear();
                txtTotalPrice.DataBindings.Clear();


                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtTotalPrice.DataBindings.Add("Text", source, "TotalPrice");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var OrderDetail = new OrderDetail
                {
                    OrderId = string.Format(txtOrderId.Text),
                    Discount = double.Parse(txtDiscount.Text.ToString()),
                    Quantity = int.Parse(txtQuantity.Text.ToString()),
                    TotalPrice = (double?)decimal.Parse(txtTotalPrice.Text.ToString()),

                };
                if (InsertOrUpdate == false)
                {
                    OrderDetailRepository.InsertOrderDetail(OrderDetail);
                }
                else
                {
                    OrderDetailRepository.UpdateOrderDetail(OrderDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Order detail" : "Update an order detail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }
    }
}
