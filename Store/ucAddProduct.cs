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
        List<ProductDetailDTO> PDLs;
        ProductDetailDTO item;

        CategoryBUS category = new CategoryBUS();
        ProductBUS ProBUS = new ProductBUS();
        ImportInvoiceBUS Inc = new ImportInvoiceBUS();
        NewAProductBUS NBUS = new NewAProductBUS();
        ProductDetailBUS PDBUS = new ProductDetailBUS();

        

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
            
            List<ImportInvoiceDTO> ls = new List<ImportInvoiceDTO>();
            ls = Inc.LayHoaDonLonNhat();
            cboID.DataSource = ls;
            cboID.ValueMember = "idHoaDon";
            cboID.DisplayMember = "idHoaDon";
            LoadDanhMuc();
            LoadProduct();
            LoadSize();
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

        private void LoadSize()
        {
            PDLs = PDBUS.LayTatCaPD(cboProductName.SelectedValue.ToString());
            cboSize.DataSource = PDLs;
            cboSize.DisplayMember = "size";
            cboSize.ValueMember = "size";
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

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSize();
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
    }
}
