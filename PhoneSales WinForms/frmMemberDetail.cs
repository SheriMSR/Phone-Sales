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
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
            cboRole.SelectedIndex = 0;
        }

        IMemberRepository memberRepository = new MemberRepository();
        public bool InsertOrUpdate { get; set; }
        public Member memberInfo { get; set; }
        private string roleCheck;

        public frmMemberDetail(string myCheck) : this()
        {
            roleCheck = myCheck;
            if (myCheck != "0")
            {
                cboRole.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtFullname.Text)
                    || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(cboRole.SelectedIndex.ToString())) {
                    MessageBox.Show("All information must be filled !","Error");
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text,"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Phone number is not valid !", "Error");
                }
                //else if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "^[0-9]+$ "))
                //{
                //    MessageBox.Show("Full name is not valid !", "Error");
                //}
                else {
                    var member = new Member
                    {
                        MemberId = txtID.Text,
                        Email = txtEmail.Text,
                        FullName = txtFullname.Text,
                        PhoneNumber = int.Parse(txtPhone.Text),
                        Password = txtPassword.Text,
                        MemberRole = cboRole.Text
                    };
                    if (InsertOrUpdate == false)
                    {
                        memberRepository.AddMember(member);
                    }
                    else
                    {
                        memberRepository.UpdateMember(member);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtID.Text = memberInfo.MemberId.ToString();
                txtID.Enabled = false;
                txtFullname.Text = memberInfo.FullName.ToString();
                txtEmail.Text = memberInfo.Email.ToString();
                txtPhone.Text = memberInfo.PhoneNumber.ToString();
                txtPassword.Text = memberInfo.Password.ToString();
                cboRole.Text = memberInfo.MemberRole.ToString();
            }
        }


    }
}
