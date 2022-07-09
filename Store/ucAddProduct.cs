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
    public partial class ucAddProduct : UserControl
    {
        List<ProductDTO> lsPro;
        List<CategoryDTO> categoryLs;
        List<InsertInvoiceDTO> IILs;

        CategoryBUS category = new CategoryBUS();
        ProductBUS ProBUS = new ProductBUS();
        ImportInvoiceBUS Inc = new ImportInvoiceBUS();
        NewAProductBUS NBUS = new NewAProductBUS();
        ProductDetailBUS PDBUS = new ProductDetailBUS();
        InsertInvoiceBUS IIBUS = new InsertInvoiceBUS();
        ImportDetailInvoiceBUS IDIBUS = new ImportDetailInvoiceBUS();

        ProductDetailDTO PD;
        ImportDetailInvoiceDTO IDI;
        InsertInvoiceDTO II;

        public ucAddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnAdd);
        }

        private void btn_MouseEnter(Button a)
        {
            a.BackColor = Color.FromArgb(255, 1, 243);
            a.ForeColor = Color.Black;
            a.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
        }

        private void btn_MouseLeave(Button a)
        {
            a.BackColor = Color.Transparent;
            a.ForeColor = Color.FromArgb(255, 1, 243);
            a.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnAdd);
        }

        private void ucAddProduct_Load(object sender, EventArgs e)
        {
            lblImportPrice.Visible = false;
            lblSalesPrice.Visible = false;
            LoadDanhMuc();
            LoadHoaDonMoiNhat();
            LoadProduct();
            LoadDGV();
            
        }
        private void LoadHoaDonMoiNhat()
        {
            List<ImportInvoiceDTO> ls = new List<ImportInvoiceDTO>();
            ls = Inc.LayHoaDonLonNhat();
            cboID.DataSource = ls;
            cboID.ValueMember = "idHoaDon";
            cboID.DisplayMember = "idHoaDon";
        }
        private void LoadDanhMuc()
        {
            categoryLs = category.LayTatCaDanhMuc();
            colCategory.DataSource = categoryLs;
            colCategory.ValueMember = "idDanhMuc";
            colCategory.DisplayMember = "tenDanhMuc";

            cboCategory.DataSource = new List<CategoryDTO>(categoryLs);
            cboCategory.DisplayMember = "tenDanhMuc";
            cboCategory.ValueMember = "idDanhMuc";
        }

        private void LoadProduct()
        {
            lsPro = ProBUS.LayDanhSachSanPham(cboCategory.SelectedValue.ToString());
            cboProductName.DataSource = lsPro;
            cboProductName.DisplayMember = "tenSanPham";
            cboProductName.ValueMember = "idSanPham";
        }

        private void LoadDGV()
        {
            IILs = IIBUS.LayTatCaHoaDonNhap(cboID.Text);
            dgvAddProduct.DataSource = IILs;
        }

        

        private void UC_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LayThongChiTietSanPham()
        {
            PD = new ProductDetailDTO();
            PD.idSanPham = cboProductName.SelectedValue.ToString();
            PD.size = float.Parse(nudSize.Value.ToString());
            PD.giaBan = decimal.Parse(txtSalesPrice.Text);
            PD.soLuong = int.Parse(nudQuantity.Value.ToString());
            PD.trangThai = 1;
        }
        private void BindingDGV()
        {
            if (II != null)
            {
                cboCategory.SelectedValue = II.idDanhMuc;
                cboProductName.SelectedValue = II.idSanPham;
                nudSize.Value = decimal.Parse(II.size.ToString());
                nudQuantity.Value = decimal.Parse(II.soLuong.ToString());
                txtImportPrice.Text = II.giaNhap.ToString();
                txtSalesPrice.Text = II.giaBan.ToString();
            }
        }

        private void LayThongTinChiTietHD()
        {
            IDI = new ImportDetailInvoiceDTO();
            IDI.idHoaDon = cboID.SelectedValue.ToString();
            IDI.idSanPham = cboProductName.SelectedValue.ToString();
            IDI.size = float.Parse(nudSize.Value.ToString());
            IDI.soLuong = int.Parse(nudQuantity.Value.ToString());
            IDI.giaNhap = decimal.Parse(txtImportPrice.Text);
        }

        private void txtImportPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtImportPrice.Text))
            {
                decimal a = decimal.Parse(txtImportPrice.Text) + (decimal.Parse(txtImportPrice.Text) / 100 * 20);
                txtSalesPrice.Text = a.ToString();
                lblImportPrice.Visible = false;
            }
            else
            {
                txtSalesPrice.Text = null;
            }
        }

        private void picInvoiceID_Click(object sender, EventArgs e)
        {
            if (Inc.ThemHDMoi(frmLogIn.id))
            {
                LoadHoaDonMoiNhat();
            }
        }

        private void picCate_Click(object sender, EventArgs e)
        {
            if (category.ThemDanhMucMoi(cboCategory.Text))
                LoadDanhMuc();
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            if (ProBUS.ThemDanhSanPhamMoi(cboCategory.SelectedValue.ToString(), cboProductName.Text))
            {
                LoadProduct();
            }
        }

        private void cboID_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImportPrice.Text))
            {
                lblImportPrice.Visible = true;
                return;
            }
            else
                lblImportPrice.Visible = false;
            if (string.IsNullOrWhiteSpace(txtSalesPrice.Text))
            {
                lblSalesPrice.Visible = true;
                return;
            }
            else
                lblImportPrice.Visible = false;
            LayThongChiTietSanPham();
            LayThongTinChiTietHD();
            if (PDBUS.ThemChiTietSanPhamMoi(PD) && IDIBUS.ThemMotChiTietHoaDonMoi(IDI))
            {
                MessageBox.Show("New product was added!", "New product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
            else
                MessageBox.Show("Fail to new product!", "New product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvAddProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAddProduct.SelectedRows.Count > 0)
            {
                II = (InsertInvoiceDTO)dgvAddProduct.SelectedRows[0].DataBoundItem;
            }
            else
                II = null;
            BindingDGV();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadProduct();
            nudSize.Value = 1;
            nudQuantity.Value = 1;
            txtImportPrice.Text = null;
            txtSalesPrice.Text = null;
            lblImportPrice.Visible = false;
            lblSalesPrice.Visible = false;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||char.IsWhiteSpace(e.KeyChar)||char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtImportPrice_Click(object sender, EventArgs e)
        {
            txtImportPrice.SelectAll();
        }

        private void txtSalesPrice_Click(object sender, EventArgs e)
        {
            txtSalesPrice.SelectAll();
        }
    }
}
