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
        List<ImportInvoiceDTO> lsHDN;
        List<SalesInvoiceDTO> lsHDB;
        List<IIIDIDTO> lsIDID;
        
        List<ProductDTO> PLs;
        List<SISDIDTO> lsSISD;
        List<AccountDTO> ALs;

        ImportInvoiceBUS HDNBUS = new ImportInvoiceBUS();
        SalesInvoiceBUS HDBBUS = new SalesInvoiceBUS();
        IIIDIBUS HDIDIDBUS = new IIIDIBUS();
        SISDIBUS HDSISD = new SISDIBUS();
        ProductBUS PBUS = new ProductBUS();
        CustomerBUS CBUS = new CustomerBUS();
        AccountBUS ABUS = new AccountBUS();

        public ucInvoice()
        {
            InitializeComponent();
        }

        private void ucReport_Load(object sender, EventArgs e)
        {
            radSales.Checked = radAll.Checked = true;
            LoadCTHDBanHangforAll();
        }
        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            
            if (frmLogIn.chucVu == "Staff")
            {
                radImport.Visible = false;
            }
            if (radAll.Checked)
                cboReport.Enabled = false;
            else if (radChoose.Checked)
                cboReport.Enabled = true;
            if (radSales.Checked)
            {
                dgvSalesInvoice.BringToFront();
                dgvImportInvoice.SendToBack();
                LoadCTHDBanHangforAll();
                if (radChoose.Checked)
                {
                    LoadcboHDB();
                    LoadTaiKhoanforSale();
                    LoadTenSanPhamforSales();
                    LoadCTHDBanHangforChoose();
                }
            }
            else if (radImport.Checked)
            {
                dgvImportInvoice.BringToFront();
                dgvSalesInvoice.SendToBack();
                LoadCTHDNhapHangforAll();
                if (radChoose.Checked)
                {
                    LoadcboHDN();
                    LoadTaiKhoanforImport();
                    LoadTenSanPhamforImport();
                    LoadCTHDNhapHangforChoose();
                }
            }
        }
        private void LoadcboHDN()
        {
            lsHDN = HDNBUS.LayTatCaHoaDon();
            cboReport.DataSource = lsHDN;
            cboReport.DisplayMember = "idHoaDon";
            cboReport.ValueMember = "idHoaDon";
        }

        private void LoadcboHDB()
        {
            lsHDB = HDBBUS.LayTatCaHDBanHang();
            cboReport.DataSource = lsHDB;
            cboReport.DisplayMember = "idHoaDon";
            cboReport.ValueMember = "idHoaDon";
        }

        private void LoadTaiKhoanforSale()
        {
            ALs = ABUS.LayTatCaTaiKhoan();
            colStaffSale.DataSource = ALs;
            colStaffSale.DisplayMember = "hoTen";
            colStaffSale.ValueMember = "idTaiKhoan";
        }
        private void LoadTaiKhoanforImport()
        {
            colStaffImport.DataSource = new List<AccountDTO>(ALs);
            colStaffImport.DisplayMember = "hoTen";
            colStaffImport.ValueMember = "idTaiKhoan";
        }
        private void LoadTenSanPhamforSales()
        {
            PLs = PBUS.LayDanhSachSanPham();
            colProductSale.DataSource = PLs;
            colProductSale.DisplayMember = "tenSanPham";
            colProductSale.ValueMember = "idSanPham";
        }
        private void LoadTenSanPhamforImport()
        {
            colProductImport.DataSource = new List<ProductDTO>(PLs);
            colProductImport.DisplayMember = "tenSanPham";
            colProductImport.ValueMember = "idSanPham";
        }
        private void LoadCTHDNhapHangforAll()
        {
            LoadTaiKhoanforImport();
            LoadTenSanPhamforImport();
            lsIDID = HDIDIDBUS.LayTatCaDanhSachCTHoaDonNhapHang();
            dgvImportInvoice.DataSource = lsIDID;
        }
        private void LoadCTHDBanHangforAll()
        {
            dgvSalesInvoice.AutoGenerateColumns = false;
            LoadTaiKhoanforSale();
            LoadTenSanPhamforSales();
            lsSISD = HDSISD.LayTatCaDanhSachCTHDBanHang();
            dgvSalesInvoice.DataSource = lsSISD;
        }
        private void LoadCTHDNhapHangforChoose()
        {
            List<IIIDIDTO> HDN = new List<IIIDIDTO>();
            HDN = HDIDIDBUS.LayTatCaDanhSachCTHoaDonNhapHang(cboReport.SelectedValue.ToString());
            dgvImportInvoice.DataSource = HDN;
        }
        private void LoadCTHDBanHangforChoose()
        {
            List<SISDIDTO> HDB = new List<SISDIDTO>();
            HDB = HDSISD.LayTatCaDanhSachCTHDBanHang(cboReport.SelectedValue.ToString());
            dgvSalesInvoice.DataSource = HDB;
        }
        private void cboReport_SelectedValueChanged(object sender, EventArgs e)
        {
            if (radImport.Checked && radChoose.Checked)
                LoadCTHDNhapHangforChoose();
            if (radSales.Checked && radChoose.Checked)
                LoadCTHDBanHangforChoose();
        }

        private void btnReFresh_Click(object sender, EventArgs e)
        {
            radImport.Enabled = radSales.Enabled = radAll.Enabled = radChoose.Enabled = true;
            radSales.Checked = radAll.Checked = true;
            LoadCTHDBanHangforAll();
        }

        private void ucInvoice_DoubleClick(object sender, EventArgs e)
        {
            dgvSalesInvoice.Refresh();
            dgvImportInvoice.Refresh();
        }
    }
}
