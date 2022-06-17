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
        List<ImportInvoiceDTO> lsHDN;
        List<SalesInvoiceDTO> lsHDB;
        ImportInvoiceBUS HDNBUS = new ImportInvoiceBUS();
        SalesInvoiceBUS HDBBUS = new SalesInvoiceBUS();
        public ucReport()
        {
            InitializeComponent();
        }

        private void ucReport_Load(object sender, EventArgs e)
        {
            radSales.Checked = true;
            dgvSalesInvoice.BringToFront();
            LoadHDB();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (frmLogIn.chucVu == "Staff")
            {
                radImport.Enabled = false;
            }
            if (radSales.Checked == true)
            {
                dgvSalesInvoice.BringToFront();
                dgvImportInvoice.SendToBack();
                LoadHDB();
            }
            else if (radImport.Checked == true)
            {
                dgvImportInvoice.BringToFront();
                dgvSalesInvoice.SendToBack();
                LoadHDN();
            }
        }

        private void LoadHDN()
        {
            lsHDN = HDNBUS.LayTatCaHoaDon();
            cboReport.DataSource = lsHDN;
            cboReport.DisplayMember = "idHoaDon";
            cboReport.ValueMember = "idHoaDon";
        }

        private void LoadHDB()
        {
            lsHDB = HDBBUS.LayTatCaHDBanHang();
            cboReport.DataSource = lsHDB;
            cboReport.DisplayMember = "idHoaDon";
            cboReport.ValueMember = "idHoaDon";
        }
    }
}
