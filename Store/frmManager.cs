using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        public frmManager(string username, string position)
        {
            InitializeComponent();
            lblUserName.Text = username;
            if(position=="Staff")
            {
                btnProduct.Enabled = false;
                btnStaff.Enabled = false;
            }
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(30, 30, 30);
            ucSearch1.BringToFront();
            lblTitle.Text = btnSearch.Text.Trim().ToUpper();
            
        }

        private void click(Button main, Button btn1,Button btn2,Button btn3,Button btn4)
        {
            main.BackColor= Color.FromArgb(30, 30, 30);
            btn1.BackColor = btn2.BackColor = btn3.BackColor = btn4.BackColor = Color.FromArgb(28, 40, 60);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            click(btnSearch, btnCart, btnProduct, btnStaff, btnReport);
            ucSearch1.BringToFront();
            lblTitle.Text = btnSearch.Text.Trim().ToUpper();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            click( btnCart, btnSearch, btnProduct, btnStaff, btnReport);
            ucCart1.BringToFront();
            lblTitle.Text = btnCart.Text.Trim().ToUpper();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            click(btnProduct, btnSearch, btnCart,  btnStaff, btnReport);
            ucAddProduct1.BringToFront();
            lblTitle.Text = btnProduct.Text.Trim().ToUpper();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            click(btnStaff, btnSearch, btnCart, btnProduct,  btnReport);
            ucAddStaff1.BringToFront();
            lblTitle.Text = btnStaff.Text.Trim().ToUpper();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            click(btnReport,btnSearch, btnCart, btnProduct, btnStaff);
            ucReport1.BringToFront();
            lblTitle.Text = btnReport.Text.Trim().ToUpper();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmLogIn frm = new frmLogIn();
                this.Hide();
                frm.Show();
            }
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            pnlClose.BackColor = picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            pnlClose.BackColor = picClose.BackColor = Color.Transparent;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to quit?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            
        }
    }
}
