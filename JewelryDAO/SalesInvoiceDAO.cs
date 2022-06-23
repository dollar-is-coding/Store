using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class SalesInvoiceDAO
    {

        public List<SalesInvoiceDTO> LayDanhSachHoaDonBanHang()
        {
            List<SalesInvoiceDTO> lsSalesInvoice = new List<SalesInvoiceDTO>();
            string strKetNoi = "Select * from HDBanHang";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(strKetNoi, connect);
            while (sdr.Read())
            {
                SalesInvoiceDTO salesInvoice = new SalesInvoiceDTO();
                salesInvoice.idHoaDon = sdr["idHoaDon"].ToString();
                salesInvoice.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                salesInvoice.idKhachHang = sdr["idKhachHang"].ToString();
                salesInvoice.ngayBan = sdr["ngayBan"].ToString();
                lsSalesInvoice.Add(salesInvoice);
            }
            sdr.Close();
            connect.Close();
            return lsSalesInvoice;
        }

        public SalesInvoiceDTO LayMaHDLonNhat()
        {
            SalesInvoiceDTO SI = null;
            string query = "Select * from HDBanHang where idHoaDon = (Select max(idHoaDon) from HDBanHang)";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                SI = new SalesInvoiceDTO();
                SI.idHoaDon = sdr["idHoaDon"].ToString();
            }
            sdr.Close();
            connect.Close();
            return SI;
        }

        public bool ThemMoiMotHoaDon()
        {
            try
            {
                string Query = "insert into HDBanhang(idHoaDon) values('')";
                SqlConnection conn = DataProvider.TaoKetNoi();
                bool ins = DataProvider.ThucThi(Query, conn);
                conn.Close();
                return ins;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatHDBanHang(SalesInvoiceDTO SI)
        {
            try
            {
                string update = "Update HDBanHang set idTaiKhoan=@idTaiKhoan, idKhachHang=@idKhachHang, ngayBan=@ngayBan where idHoaDon=@idHoaDon";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] pars = new SqlParameter[4];
                pars[0] = new SqlParameter("idTaiKhoan", SI.idTaiKhoan);
                pars[1] = new SqlParameter("idKhachHang", SI.idKhachHang);
                pars[2] = new SqlParameter("ngayBan", SI.ngayBan);
                pars[3] = new SqlParameter("idHoaDon", SI.idHoaDon);
                bool ins = DataProvider.ThucThi(update, pars, conn);
                conn.Close();
                return ins;
            }
            catch
            {
                return false;
            }
        }
    }
}
