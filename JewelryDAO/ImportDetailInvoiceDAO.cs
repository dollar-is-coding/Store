using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class ImportDetailInvoiceDAO
    {
        public bool ThemChiTietHoaDonMoi(ImportDetailInvoiceDTO IDI)
        {
            try
            {
                string strInsert = "Insert into CTHDNhapHang values (@idHoaDon,'',@idSanPham,@size,@soLuong,@giaNhap)";
                SqlConnection connect = DataProvider.TaoKetNoi();
                SqlParameter[] pars = new SqlParameter[5];
                pars[0] = new SqlParameter("idHoaDon", IDI.idHoaDon);
                pars[1] = new SqlParameter("idSanPham", IDI.idSanPham);
                pars[2] = new SqlParameter("size", IDI.size);
                pars[3] = new SqlParameter("soLuong", IDI.soLuong);
                pars[4] = new SqlParameter("giaNhap", IDI.giaNhap);
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
