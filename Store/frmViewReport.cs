using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JewelryBUS;
using JewelryDTO;
using Microsoft.Reporting.WinForms;

namespace Jewelry
{
    public partial class frmViewReport : Form
    {
        public frmViewReport()
        {
            InitializeComponent();
        }

        private void frmViewReport_Load(object sender, EventArgs e)
        {
        }
        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            pnlClose.BackColor = picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            pnlClose.BackColor = picClose.BackColor = Color.Transparent;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TatCaSanPham()
        {
            Product4ReportBUS PPD = new Product4ReportBUS();
            List<Product4ReportDTO> lst = PPD.LayTatCaCTSP();
            this.rvr.LocalReport.ReportEmbeddedResource = "Jewelry.rpAllProducts.rdlc";
            this.rvr.LocalReport.DataSources.Add(new ReportDataSource("DSSP", lst));
            this.rvr.RefreshReport();
        }

        public void TatCaSanPhamTheoLoai(string tenDanhMuc)
        {
            Product4ReportBUS PPD = new Product4ReportBUS();
            List<Product4ReportDTO> lst = PPD.LayTatCaCTSP(tenDanhMuc);
            this.rvr.LocalReport.ReportEmbeddedResource = "Jewelry.rpProducts4Category.rdlc";
            this.rvr.LocalReport.DataSources.Add(new ReportDataSource("DSSPLoai", lst));
            this.rvr.LocalReport.SetParameters(new ReportParameter("parCategory",tenDanhMuc));
            this.rvr.RefreshReport();
        }

        public void TatCaHDNTheoThang(int month, int year)
        {
            Import4ReportBUS I4R = new Import4ReportBUS();
            List<Import4ReportDTO> ls = I4R.TatCaHDNTheoThang(month, year);
            this.rvr.LocalReport.ReportEmbeddedResource = "Jewelry.rpImport4Month.rdlc";
            this.rvr.LocalReport.DataSources.Add(new ReportDataSource("DSHDN", ls));
            this.rvr.LocalReport.SetParameters(new ReportParameter("month", month.ToString()));
            this.rvr.LocalReport.SetParameters(new ReportParameter("year", year.ToString()));
            this.rvr.RefreshReport();
        }

        public void TatCaHDBTheoThang(int month, int year)
        {
            Sales4ReportBUS S4R = new Sales4ReportBUS();
            List<Sales4ReportDTO> ls = S4R.TatCaHDBTheoThang(month, year);
            this.rvr.LocalReport.ReportEmbeddedResource = "Jewelry.rpSales4Month.rdlc";
            this.rvr.LocalReport.DataSources.Add(new ReportDataSource("DSHDB", ls));
            this.rvr.LocalReport.SetParameters(new ReportParameter("parMonth", month.ToString()));
            this.rvr.LocalReport.SetParameters(new ReportParameter("parYear", year.ToString()));
            this.rvr.RefreshReport();
        }

    }
}
