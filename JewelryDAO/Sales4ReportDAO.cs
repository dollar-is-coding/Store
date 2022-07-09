using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class Sales4ReportDAO
    {
        public List<Sales4ReportDTO> LayTatCaHDBTheoThang(int month,int year)
        {
            List<Sales4ReportDTO> ls = new List<Sales4ReportDTO>();
            string query = "select HD.idHoaDon, CTHD.idSanPham, SP.tenSanPham, CTHD.size, CTHD.soLuong, CTHD.giaBan, tenDanhMuc, KH.hoTen, TK.hoTen, ngayBan from TaiKhoan TK, KhachHang KH, HDBanHang HD, CTHDBanHang CTHD, ChiTietSanPham CTSP, SanPham SP, DanhMuc DM where HD.idTaiKhoan = TK.idTaiKhoan and HD.idKhachHang = KH.idKhachHang and HD.idHoaDon = CTHD.idHoaDon and CTHD.idSanPham = CTSP.idSanPham and CTHD.size = CTSP.size and SP.idSanPham = CTSP.idSanPham and SP.idDanhMuc = DM.idDanhMuc and MONTH(ngayBan)= @month and YEAR(ngayBan)= @year";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("month", month);
            pars[1] = new SqlParameter("year", year);
            SqlDataReader sdr = DataProvider.TruyVan(query, pars, connect);
            while (sdr.Read())
            {
                Sales4ReportDTO S4R = new Sales4ReportDTO();
                S4R.idHoaDon = sdr["idHoaDon"].ToString();
                S4R.idSanPham = sdr["idSanPham"].ToString();
                S4R.tenSanPham = sdr["tenSanPham"].ToString();
                S4R.size = float.Parse(sdr["size"].ToString());
                S4R.soLuong = int.Parse(sdr["soLuong"].ToString());
                S4R.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                S4R.tenDanhMuc = sdr["tenDanhMuc"].ToString();
                S4R.tenKhachHang = sdr["hoTen"].ToString();
                S4R.tenTaiKhoan = sdr["hoTen"].ToString();
                S4R.ngayBan = sdr["ngayBan"].ToString();
                ls.Add(S4R);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
