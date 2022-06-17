using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDAO
{
    public class ImportInvoiceDAO
    {
        public List<ImportInvoiceDTO> LayDanhSachHoaDon()
        {
            List<ImportInvoiceDTO> lsInc = new List<ImportInvoiceDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select *from HDNhapHang";
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
            while (sdr.Read())
            {
                ImportInvoiceDTO hd = new ImportInvoiceDTO();
                hd.idHoaDon = sdr["idHoaDon"].ToString();
                hd.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                hd.ngayNhap = sdr["ngayNhap"].ToString();
                lsInc.Add(hd);
            }
            sdr.Close();
            conn.Close();
            return lsInc;
        }
    }
}
