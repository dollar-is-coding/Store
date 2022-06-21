using JewelryBUS;
using JewelryDTO;
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
    public partial class ucSearch : UserControl
    {
        CategoryBUS CBUS = new CategoryBUS();
        PPDBUS PPDBUS = new PPDBUS();
        List<CategoryDTO> CLs;
        List<PPDDTO> PPDLs;
        PPDDTO item;
        public ucSearch()
        {
            InitializeComponent();
        }

        private void btnAddToCart_MouseEnter(object sender, EventArgs e)
        {
            btnAddToCart.BackColor = Color.FromArgb(255, 1, 243);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
        }

        private void btnAddToCart_MouseLeave(object sender, EventArgs e)
        {
            btnAddToCart.BackColor = Color.Transparent;
            btnAddToCart.ForeColor = Color.FromArgb(255, 1, 243);
            btnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            dgvSearch.AutoGenerateColumns = false;
            radAll.Checked = true;
            cboSearch.Enabled = false;
            LoadChiTietSanPham();
        }

        private void LoadDanhMuc()
        {
            CLs = CBUS.LayTatCaDanhMuc();
            cboSearch.DataSource = CLs;
            cboSearch.DisplayMember = "tenDanhMuc";
            cboSearch.ValueMember = "idDanhMuc";
            colCategory.DataSource = new List<CategoryDTO>(CLs);
            colCategory.DisplayMember = "tenDanhMuc";
            colCategory.ValueMember = "idDanhMuc";
        }

        private void LoadChiTietSanPham()
        {
            PPDLs = PPDBUS.LayTatCaChiTietSanPham();
            dgvSearch.DataSource = PPDLs;
        }
        private void LoadChiTietSanPhamforChoose()
        {
            List<PPDDTO> PPD = new List<PPDDTO>();
            PPD = PPDBUS.LayTatCaChiTietSanPham(cboSearch.SelectedValue.ToString());
            dgvSearch.DataSource = PPD;
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                item = (PPDDTO)dgvSearch.SelectedRows[0].DataBoundItem;
            }
            else
            {
                item = null;
            }
            BindingItem();
        }

        private void BindingItem()
        {
            if (item != null)
            {
                lblName.Text = item.tenSanPham;
                lblSize.Text = item.size.ToString();
                lblPrice.Text = string.Format("{0:0,0 vnđ}", decimal.Parse(item.giaBan.ToString()));
                lblQuantity.Text = item.soLuong.ToString();
                nudChoose.Maximum = int.Parse(item.soLuong.ToString());
            }
        }

        private void nudChoose_Click(object sender, EventArgs e)
        {
            nudChoose.Select(0, nudChoose.Text.Length);
        }

        private void pnlSearch_Click(object sender, EventArgs e)
        {
            lblName.Focus();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
                cboSearch.Enabled = false;
                txtSearch.Enabled = false;
                LoadChiTietSanPham();
            }
            if (radChoose.Checked)
            {
                cboSearch.Enabled = true;
                txtSearch.Enabled = true;
                LoadChiTietSanPhamforChoose();
                
            }
        }

        private void cboSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (radChoose.Checked)
                LoadChiTietSanPhamforChoose();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            if (txtSearch.Text != "Search Product ID..." || !string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                List<PPDDTO> PPD = new List<PPDDTO>();
                PPD = PPDBUS.LayTatCaChiTietSanPham(cboSearch.SelectedValue.ToString(), txtSearch.Text);
                dgvSearch.DataSource = PPD;
            }
        }

        private void ucSearch_Click(object sender, EventArgs e)
        {
            lblName.Focus();
        }
    }
}
