using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JewelryDTO;
using JewelryBUS;

namespace Jewelry
{
    public partial class ucReport : UserControl
    {
        public ucReport()
        {
            InitializeComponent();
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.ForeColor = Color.Black;
            btnOk.FlatAppearance.BorderColor = Color.FromArgb(28, 40, 60);
            btnOk.BackColor = Color.FromArgb(255, 1, 243);
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.ForeColor = Color.FromArgb(255, 1, 243);
            btnOk.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
            btnOk.BackColor = Color.Transparent;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radAllProducts.Checked)
            {
                frmViewReport frm = new frmViewReport();
                frm.TatCaSanPham();
                frm.ShowDialog();
            }
            if (radProducts4Cate.Checked)
            {
                frmViewReport frm = new frmViewReport();
                frm.TatCaSanPhamTheoLoai(cbo.Text);
                frm.ShowDialog();
            }
            if (radImport.Checked)
            {
                int month = dtp.Value.Month;
                int year = dtp.Value.Year;
                frmViewReport frm = new frmViewReport();
                frm.TatCaHDNTheoThang(month, year);
                frm.ShowDialog();
            }
            if (radSales.Checked)
            {
                int month = dtp.Value.Month;
                int year = dtp.Value.Year;
                frmViewReport frm = new frmViewReport();
                frm.TatCaHDBTheoThang(month, year);
                frm.ShowDialog();
            }
        }

        private void ucReport_Load(object sender, EventArgs e)
        {
            CategoryBUS category = new CategoryBUS();
            List<CategoryDTO> lst = category.LayTatCaDanhMuc();
            cbo.DataSource = lst;
            cbo.ValueMember = "idDanhMuc";
            cbo.DisplayMember = "tenDanhMuc";
            radAllProducts.Checked = true;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (radAllProducts.Checked)
            {
                cbo.Visible = false;
                dtp.Visible = false;
            }
            if (radProducts4Cate.Checked)
            {
                cbo.Visible = true;
                dtp.Visible = false;
            } 
            if (radImport.Checked || radSales.Checked)
            {
                dtp.Visible = true;
                cbo.Visible = false;
            }
                
        }
    }
}
