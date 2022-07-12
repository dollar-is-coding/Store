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
    public partial class ucInvoice : UserControl
    {
        ImportInvoiceBUS HDNBUS = new ImportInvoiceBUS();
        SalesInvoiceBUS HDBBUS = new SalesInvoiceBUS();
        CustomerBUS CBUS = new CustomerBUS();

        public ucInvoice()
        {
            InitializeComponent();
        }

        private void ucReport_Load(object sender, EventArgs e)
        {
            if (frmLogIn.chucVu == "Staff")
            {
                radImport.Visible = false;
            }
            dgvImportInvoice.AutoGenerateColumns = dgvSalesInvoice.AutoGenerateColumns = false;
            radSales.Checked = true;
            LoadCTHDBH();
        }

        private void LoadCTHDBH()
        {
            LoadTaiKhoanforSale();
            LoadTenSanPhamforSales();
            SISDIBUS HDSISD = new SISDIBUS();
            List<SISDIDTO> lsSISD;
            if (txtSearch.Text == "Search invoice ID...")
                lsSISD = HDSISD.LayTatCaDanhSachCTHDBanHang(frmLogIn.id);
            else
                lsSISD = HDSISD.LayTatCaDanhSachCTHDBanHang(frmLogIn.id, txtSearch.Text);
            dgvSalesInvoice.DataSource = lsSISD;
        }

        private void LoadCTHDNH()
        {
            LoadTaiKhoanforImport();
            LoadTenSanPhamforImport();
            IIIDIBUS HDIDIDBUS = new IIIDIBUS();
            List<IIIDIDTO> lsIDID;
            if (txtSearch.Text == "Search invoice ID...")
                lsIDID = HDIDIDBUS.LayTatCaDanhSachCTHoaDonNhapHang();
            else
                lsIDID = HDIDIDBUS.LayTatCaDanhSachCTHoaDonNhapHang(txtSearch.Text);
            dgvImportInvoice.DataSource = lsIDID;
        }

        private void LoadTaiKhoanforSale()
        {
            AccountBUS ABUS = new AccountBUS();
            List<AccountDTO> ALs;
            ALs = ABUS.LayTatCaTaiKhoan();
            colStaffSale.DataSource = ALs;
            colStaffSale.DisplayMember = "hoTen";
            colStaffSale.ValueMember = "idTaiKhoan";
        }
        private void LoadTaiKhoanforImport()
        {
            AccountBUS ABUS = new AccountBUS();
            List<AccountDTO> ALs;
            ALs = ABUS.LayTatCaTaiKhoan();
            colStaffImport.DataSource = ALs;
            colStaffImport.DisplayMember = "hoTen";
            colStaffImport.ValueMember = "idTaiKhoan";
        }
        private void LoadTenSanPhamforSales()
        {
            ProductBUS PBUS = new ProductBUS();
            List<ProductDTO> PLs;
            PLs = PBUS.LayDanhSachSanPham();
            colProductSale.DataSource = PLs;
            colProductSale.DisplayMember = "tenSanPham";
            colProductSale.ValueMember = "idSanPham";
        }
        private void LoadTenSanPhamforImport()
        {
            ProductBUS PBUS = new ProductBUS();
            List<ProductDTO> PLs;
            PLs = PBUS.LayDanhSachSanPham();
            colProductImport.DataSource = PLs;
            colProductImport.DisplayMember = "tenSanPham";
            colProductImport.ValueMember = "idSanPham";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            if (radSales.Checked)
                LoadCTHDBH();
            if (radImport.Checked)
                LoadCTHDNH();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void ucInvoice_Click(object sender, EventArgs e)
        {
            btnSearch.Focus();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if(radSales.Checked)
            {
                dgvSalesInvoice.BringToFront();
                LoadCTHDBH();
            }
            if (radImport.Checked)
            {
                dgvImportInvoice.BringToFront();
                LoadCTHDNH();
            }
        }
    }
}
