using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JewelryDTO;
using JewelryBUS;

namespace Jewelry
{
    public partial class frmLogIn : Form
    {
        AccountBUS accountB = new AccountBUS();
        public static string chucVu;
        public static string staff;
        public static string id;
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lblInvalidUserName.Visible = false;
            lblInValidPassword.Visible = false;
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.FromArgb(255, 1, 243);
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtUserName.ForeColor = Color.White;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.White;
            txtPassword.PasswordChar = '*';
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || txtUserName.Text == "User Name")
            {
                txtUserName.Focus();
                lblInvalidUserName.Visible = true;
                lblInValidPassword.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Password")
            {
                txtPassword.Focus();
                lblInValidPassword.Visible = true;
                lblInvalidUserName.Visible = false;
            }
            else
            {
                AccountDTO account = accountB.DangNhap(txtUserName.Text);
                if (account == null)
                {
                    txtUserName.Focus();
                    lblInvalidUserName.Visible = true;
                    lblInValidPassword.Visible = false;
                }
                else if(txtPassword.Text!=account.matKhau)
                {
                    txtPassword.Focus();
                    lblInValidPassword.Visible = true;
                    lblInvalidUserName.Visible = false;
                }
                else
                {
                    frmManager frm = new frmManager(account.hoTen,account.chucVu);
                    chucVu = account.chucVu;
                    staff = account.hoTen;
                    id = account.idTaiKhoan;
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void picEye_MouseDown(object sender, MouseEventArgs e)
        {
            if(txtPassword.Text!="Password")
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void picEye_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text != "Password")
                txtPassword.PasswordChar = '*';
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
            pnlClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(255, 1, 243);
            pnlClose.BackColor = Color.FromArgb(255, 1, 243);
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void frmLogIn_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = label1;
        }

        
    }
}
