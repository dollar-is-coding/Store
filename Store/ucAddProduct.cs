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
        //List<ProductDetailDTO> PDLs;
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

        public ucAddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnAdd);
        }
        

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnEdit);
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

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnEdit);
        }

        private void ucAddProduct_Load(object sender, EventArgs e)
        {
            LoadHoaDonMoiNhat();
            LoadDanhMuc();
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
            cboCategory.DataSource = categoryLs;
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

        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnRemove);
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnRemove);
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
            else
                MessageBox.Show("Them moi khong thanh cong");
        }

        private void picCate_Click(object sender, EventArgs e)
        {
            if (category.ThemDanhMucMoi(cboCategory.Text))
                LoadDanhMuc();
            else
                MessageBox.Show("Them danh muc moi khong thanh cong");
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            if (ProBUS.ThemDanhSanPhamMoi(cboCategory.SelectedValue.ToString(), cboProductName.Text))
            {
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Them san pham moi khong thanh cong");
            }
        }

        private void cboID_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImportPrice.Text) || string.IsNullOrWhiteSpace(txtSalesPrice.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }
            LayThongChiTietSanPham();
            LayThongTinChiTietHD();
            if (PDBUS.ThemChiTietSanPhamMoi(PD)&& IDIBUS.ThemMotChiTietHoaDonMoi(IDI))
            {
                MessageBox.Show("Thêm mới thành công");
                LoadDGV();
            }
            else
                MessageBox.Show("Thêm không thành công!");
        }
    }
}
