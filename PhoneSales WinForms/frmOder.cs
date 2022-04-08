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
    public partial class frmOrder : Form
    {
        public IOrderRepository OrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfor { get; set; }
        IOrderRepository orderRepository = new OrderRepository();
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {

            txtOrderID.Enabled = !InsertOrUpdate;
            txtMemberID.Enabled = !InsertOrUpdate;
            txtOrderDate.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtOrderID.Text = OrderInfor.orderId.ToString();
                txtOrderDate.Text = DateTime.Now.ToString();
                txtMemberID.Text = OrderInfor.MemberId.ToString();
            ;
            }
            else
            {
                //Register this event to open the frmMemberDetail form that performs updating
                dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail frm = new frmOrderDetail
            {
              
                Text = "Update order detail",
                InsertOrUpdate = true,
                OrderInfor = GetOrderObject(),
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member updated
                source.Position = source.Count - 1;
            }
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtOrderID.Text = string.Empty;         
        }
        //-----------------------------------------------
        private OrderDetail GetOrderObject()
        {
            OrderDetail member = null;
            try
            {
                member = new OrderDetail
                {
                    OrderId = string.Format(txtOrderID.Text),
                    ProductId = string.Format(txtProductID.Text),
                    Discount = double.Parse(txtDiscount.Text.ToString()),
                    Quantity = int.Parse(txtQuantity.Text.ToString()),
                    TotalPrice = (double?)decimal.Parse(txtTotalPrice.Text.ToString()),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return member;
        }

        public void LoadMemberList()
        {
            var members = OrderDetailRepository.GetOrders();

            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.orderId);
                txtOrderID.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order detail list");
            }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDetail frm = new frmOrderDetail
            {
              
                Text = "Add Order Detail",
                InsertOrUpdate = false,
                OrderDetailRepository = (IOrderDetailRepository)OrderDetailRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetOrderObject();
                OrderDetailRepository.DeleteOrderDetail(member.OrderId, member.ProductId);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete an order detail");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Order = new Order
                {
                    orderId = string.Format(txtOrderID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    MemberId = string.Format(txtMemberID.Text),

                };
                if (InsertOrUpdate == false)
                {
                    OrderDetailRepository.InsertOrder(Order);
                }
                else
                {
                    OrderDetailRepository.UpdateOrder(Order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update a order detail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();


        public void LoadMemberLList()
        {
            var members = memberRepository.GetMembers();

            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.MemberId);
                txtMemberID.DataBindings.Clear();


                txtMemberID.DataBindings.Add("Text", source, "MemberId");


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        //------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            LoadMemberLList();
        }
    }
}
