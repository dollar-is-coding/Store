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
        List<ImportInvoiceDTO> lsInc;
        CategoryBUS category = new CategoryBUS();
        ProductBUS ProBUS = new ProductBUS();
        ImportInvoiceBUS Inc = new ImportInvoiceBUS();
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

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnEdit);
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
            LoadProduct();
            LoadDanhMuc();
            LoadHoaDon();
            LoadSize();
        }
        private void LoadProduct()
        {
            lsPro = ProBUS.LayDanhSachSanPham();
            cboProductName.DataSource = lsPro;
            cboProductName.DisplayMember = "tenSanPham";
            cboProductName.ValueMember = "idSanPham";
        }
        private void LoadDanhMuc()
        {         
            categoryLs  = category.LayTatCaDanhMuc();
            cboCategoryName.DataSource = categoryLs;
            cboCategoryName.DisplayMember = "tenDanhMuc";
            cboCategoryName.ValueMember = "idDanhMuc";
        }
        private void LoadHoaDon()
        {
            lsInc = Inc.LayTatCaHoaDon();
            cboInvoiceID.DataSource = lsInc;
            cboInvoiceID.DisplayMember = "idHoaDon";
            cboInvoiceID.ValueMember = "idHoaDon";
        }
        private void LoadSize()
        {
            for (int i = 1; i <= 20; i++)
            {
                cboSize.Items.Add(i);
            }
        }
    }
}
