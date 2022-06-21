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
                hd.ngayNhap = DateTime.Parse(sdr["ngayNhap"].ToString()).Date;
                lsInc.Add(hd);
            }
            sdr.Close();
            conn.Close();
            return lsInc;
        }

        public List<ImportInvoiceDTO> LayIDHoaDonLonNhat()
        {
            List<ImportInvoiceDTO> ls = new List<ImportInvoiceDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "select * from HDNhapHang where idHoaDon = (Select max(idHoaDon) from HDNhapHang)";
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
            while (sdr.Read())
            {
                ImportInvoiceDTO HD = new ImportInvoiceDTO();
            HD.idHoaDon = sdr["idHoaDon"].ToString();
            HD.idTaiKhoan = sdr["idTaiKhoan"].ToString();
            HD.ngayNhap = DateTime.Parse(sdr["ngayNhap"].ToString()).Date;
                ls.Add(HD);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
        public bool  ThemHoaDonNhap(string idTaiKhoan)
        {
            try
            {
                string strIns = "insert into HDNhapHang(idHoaDon,idTaiKhoan) values ('',@idTaiKhoan)";
                SqlParameter par = new SqlParameter("idTaiKhoan", idTaiKhoan);
                SqlConnection connect = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strIns, par, connect);
                connect.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }
    }
}
