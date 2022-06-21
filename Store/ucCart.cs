﻿using System;
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
    public partial class ucCart : UserControl
    {
        public ucCart()
        {
            InitializeComponent();
        }

        private void btThanhToan_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnThanhToan);
        }

        private void btn_MouseEnter(Button a)
        {
            a.BackColor = Color.FromArgb(255, 1, 243);
            a.ForeColor = Color.Black;
            a.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
        }

        private void btnThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnThanhToan);
        }

        private void btn_MouseLeave(Button a)
        {
            a.BackColor = Color.Transparent;
            a.ForeColor = Color.FromArgb(255, 1, 243);
            a.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
        }

        private void ucCart_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToShortDateString();
            lblStaffName.Text = frmLogIn.staff;
        }

        private void txtCustomer_Click(object sender, EventArgs e)
        {
            txtCustomer.SelectAll();
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.SelectAll();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            txtCustomer.ForeColor = Color.Black;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.ForeColor = Color.Black;
        }

        private void ucCart_Click(object sender, EventArgs e)
        {
            lblStaffName.Focus();
        }

        private void pnlCart_Click(object sender, EventArgs e)
        {
            lblStaffName.Focus();
        }
    }
}
