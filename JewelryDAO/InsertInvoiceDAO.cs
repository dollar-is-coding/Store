using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class InsertInvoiceDAO
    {
        public List<InsertInvoiceDTO> LayDanhSachHoaDonNhap(string idHoaDon)
        {
            List<InsertInvoiceDTO> ls = new List<InsertInvoiceDTO>();
            string query = "Select HD.idHoaDon,  CTHD.idCTHD, SP.idDanhMuc, SP.idSanPham, SP.tenSanPham, CTSP.size, CTHD.soLuong, giaNhap, giaBan from HDNhapHang HD,CTHDNhapHang CTHD, SanPham SP, ChiTietSanPham CTSP where HD.idHoaDon = CTHD.idHoaDon and SP.idSanPham = CTSP.idSanPham and CTHD.idSanPham = CTSP.idSanPham and CTHD.size = CTSP.size and HD.idHoaDon = @idHoaDon";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter par = new SqlParameter("idHoaDon", idHoaDon);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                InsertInvoiceDTO invoice = new InsertInvoiceDTO();
                invoice.idHoaDon = sdr["idHoaDon"].ToString();
                invoice.idCTHD = sdr["idCTHD"].ToString();
                invoice.idDanhMuc = sdr["idDanhMuc"].ToString();
                invoice.idSanPham = sdr["idSanPham"].ToString();
                invoice.tenSanPham = sdr["tenSanPham"].ToString();
                invoice.size = float.Parse(sdr["size"].ToString());
                invoice.soLuong = int.Parse(sdr["soLuong"].ToString());
                invoice.giaNhap = decimal.Parse(sdr["giaNhap"].ToString());
                invoice.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                ls.Add(invoice);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }

       
    }
}
