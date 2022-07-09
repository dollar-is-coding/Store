using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class Import4ReportDAO
    {
        public List<Import4ReportDTO> LayHDTheoThang(int month, int year)
        {
            List<Import4ReportDTO> ls = new List<Import4ReportDTO>();
            string select = "select HDN.idHoaDon, SP.idSanPham, SP.tenSanPham, CTSP.size, CTHD.soLuong, CTHD.giaNhap, DM.tenDanhMuc, TK.hoTen, HDN.ngayNhap from TaiKhoan TK, HDNhapHang HDN, CTHDNhapHang CTHD, ChiTietSanPham CTSP, SanPham SP, DanhMuc DM where TK.idTaiKhoan = HDN.idTaiKhoan and HDN.idHoaDon = CTHD.idHoaDon and CTHD.idSanPham = CTSP.idSanPham and CTHD.size = CTSP.size and CTSP.idSanPham = SP.idSanPham and SP.idDanhMuc = DM.idDanhMuc and MONTH(HDN.ngayNhap)= @month and YEAR(HDN.ngayNhap)= @year";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("month", month);
            pars[1] = new SqlParameter("year", year);
            SqlDataReader sdr = DataProvider.TruyVan(select, pars, connect);
            while (sdr.Read())
            {
                Import4ReportDTO I4R = new Import4ReportDTO();
                I4R.idHoaDon = sdr["idHoaDon"].ToString();
                I4R.idSanPham = sdr["idSanPham"].ToString();
                I4R.tenSanPham = sdr["tenSanPham"].ToString();
                I4R.size = float.Parse(sdr["size"].ToString());
                I4R.soLuong = int.Parse(sdr["soLuong"].ToString());
                I4R.giaNhap = decimal.Parse(sdr["giaNhap"].ToString());
                I4R.tenDanhMuc = sdr["tenDanhMuc"].ToString();
                I4R.hoTen = sdr["hoTen"].ToString();
                I4R.ngayNhap = sdr["ngayNhap"].ToString();
                ls.Add(I4R);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
