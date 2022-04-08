using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Object.Models;
using Data_Access.Repository;


namespace PhoneSales_WinForms
{
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        private string roleCheck;

        public frmMemberManagement(string myCheck) : this()
        {
            roleCheck = myCheck;
            if (myCheck != "0")
            {
                btnNew.Enabled = false;
                btnDelete.Visible = false;
                btnSearch.Enabled = false;
                txtSearchName.Enabled = false;
            }
        }

        public void ClearText()
        {
            txtID.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }

        public void LoadMemberList()
        {
            try
            {
                var members = memberRepository.GetMembers();
                source = new BindingSource();
                source.DataSource = members;

                txtID.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtRole.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtFullName.DataBindings.Add("Text", source, "FullName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtPhone.DataBindings.Add("Text", source, "PhoneNumber");
                txtRole.DataBindings.Add("Text", source, "MemberRole");

                dgvListView.DataSource = null;
                dgvListView.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        public void LoadMemberSingle()
        {
            try
            {
                var member = memberRepository.GetMemberByID(roleCheck);
                source = new BindingSource();
                source.DataSource = member;

                txtID.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtRole.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtFullName.DataBindings.Add("Text", source, "FullName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtPhone.DataBindings.Add("Text", source, "PhoneNumber");
                txtRole.DataBindings.Add("Text", source, "MemberRole");

                dgvListView.DataSource = null;
                dgvListView.DataSource = source;
                if (member == null)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = txtID.Text,
                    FullName = txtFullName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = int.Parse(txtPhone.Text),
                    MemberRole = txtRole.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvListView.CellDoubleClick += DgvListView_CellDoubleClick;

        }

        public void btnLoad_Click(object sender, EventArgs e)
        {
            if (roleCheck != "0")
            {
                LoadMemberSingle();
            }
            else
                LoadMemberList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add Member",
                InsertOrUpdate = false
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void DgvListView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail(roleCheck)
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                memberInfo = GetMemberObject()
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                btnLoad_Click(sender, e);
                source.Position = source.Count - 1;
            }
        }

        private void dgvListView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure deleting this Member ?", "Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    var member = new Member
                    {
                        MemberId = txtID.Text
                    };
                    memberRepository.RemoveMember(member);
                    LoadMemberList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure want to exit ?", "Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                var mname = txtSearchName.Text;
                var mem = memberRepository.SearchMemByName(mname);

                source = new BindingSource();
                source.DataSource = mem;

                txtID.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtRole.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtFullName.DataBindings.Add("Text", source, "FullName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtPhone.DataBindings.Add("Text", source, "PhoneNumber");
                txtRole.DataBindings.Add("Text", source, "MemberRole");

                dgvListView.DataSource = null;
                dgvListView.DataSource = source;

                if (mem.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch 
            {
                MessageBox.Show("Member is not existed !", "Error");
            }
        }
    }
}
