using Business_Object.Models;
using Data_Access.Repository;
using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace PhoneSales_WinForms
{
    public partial class frmLogin : Form
    {
        IMemberRepository  memberRepository = new MemberRepository();
        //Thread th;

        public frmLogin()
        {
            InitializeComponent();
        }

        //public void open(object obj)
        //{
        //    Application.Run(new frmMain());
        //}

        private void btnLog_Click(object sender, EventArgs e)
        {
            var member = memberRepository.GetMemberByEmail(txtUserName.Text);
            if (txtUserName.Text.Equals(member.Email) && txtPassword.Text.Equals(member.Password))
            {
                if (member.MemberRole.Equals("Admin"))
                {
                    this.Hide();
                    frmMain frm = new frmMain("0");
                    frm.Show();

                    //this.Close();
                    //th = new Thread(open);
                    //th.SetApartmentState(ApartmentState.STA);
                    //frmMain frm = new frmMain("0");
                    //th.Start();
                }
                else
                {
                    this.Hide();
                    frmMain frmMemberManagement = new frmMain(member.MemberId);
                    frmMemberManagement.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Email or Password !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    }
}