using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class SalesDetailInvoiceDAO
    {
        public List<SalesDetailInvoiceDTO> LayDanhSachCTHDBanTheoID(string idHoaDon)
        {
            List<SalesDetailInvoiceDTO> ls = new List<SalesDetailInvoiceDTO>();
            string query = "select * from CTHDBanHang where idHoaDon=@idHoaDon";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter par = new SqlParameter("idHoaDon", idHoaDon);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                SalesDetailInvoiceDTO SDI = new SalesDetailInvoiceDTO();
                SDI.idHoaDon = sdr["idHoaDon"].ToString();
                SDI.idCTHD = sdr["idCTHD"].ToString();
                SDI.idSanPham = sdr["idSanPham"].ToString();
                SDI.size = float.Parse(sdr["size"].ToString());
                SDI.soLuong = int.Parse(sdr["soLuong"].ToString());
                ls.Add(SDI);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
        public bool ThemMotChiTietHDBanMoi(SalesDetailInvoiceDTO SDI)
        {
            try
            {
                string strInsert = "Insert into CTHDBanHang values (@idHoaDon,'',@idSanPham,@size,@soLuong)";
                SqlParameter[] pars = new SqlParameter[4];
                pars[0] = new SqlParameter("idHoaDon", SDI.idHoaDon);
                pars[1] = new SqlParameter("idSanPham", SDI.idSanPham);
                pars[2] = new SqlParameter("size", SDI.size);
                pars[3] = new SqlParameter("soLuong", SDI.soLuong);
                SqlConnection connect = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strInsert, pars, connect);
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
