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
    }
}
