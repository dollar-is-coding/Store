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
                SDI.idSanPham = sdr["idSanPham"].ToString();
                SDI.size = float.Parse(sdr["size"].ToString());
                SDI.soLuong = int.Parse(sdr["soLuong"].ToString());
                SDI.giaBan = decimal.Parse(sdr["giaBan"].ToString());
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
                string strInsert = "Insert into CTHDBanHang values (@idHoaDon,@idSanPham,@size,@soLuong,@giaBan)";
                SqlParameter[] pars = new SqlParameter[5];
                pars[0] = new SqlParameter("idHoaDon", SDI.idHoaDon);
                pars[1] = new SqlParameter("idSanPham", SDI.idSanPham);
                pars[2] = new SqlParameter("size", SDI.size);
                pars[3] = new SqlParameter("soLuong", SDI.soLuong);
                pars[4] = new SqlParameter("giaBan", SDI.giaBan);
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
