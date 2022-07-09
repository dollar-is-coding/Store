using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDAO
{
    public class IIIDIDAO
    {
        public List<IIIDIDTO> LayDanhSachCTHoaDonNhapHang()
        {
            List<IIIDIDTO> ls = new List<IIIDIDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "select * from HDNhapHang hd,CTHDNhapHang cthd where hd.idHoaDon=cthd.idHoaDon";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                IIIDIDTO IDID = new IIIDIDTO();
                IDID.idHoaDon = sdr["idHoaDon"].ToString();
                IDID.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                IDID.idSanPham = sdr["idSanPham"].ToString();
                IDID.size =float.Parse(sdr["size"].ToString());
                IDID.soLuong = int.Parse(sdr["soLuong"].ToString());
                IDID.giaNhap = decimal.Parse(sdr["giaNhap"].ToString());
                IDID.ngayNhap = DateTime.Parse(sdr["ngayNhap"].ToString()).Date;
                ls.Add(IDID);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }

        public List<IIIDIDTO> LayDanhSachCTHoaDonNhapHang(string idHoaDon)
        {
            List<IIIDIDTO> ls = new List<IIIDIDTO>();
            string query = "select * from HDNhapHang hd,CTHDNhapHang cthd where hd.idHoaDon=cthd.idHoaDon and cthd.idHoaDon=@idHoaDon";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter par = new SqlParameter("idHoaDon", idHoaDon);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                IIIDIDTO IDID = new IIIDIDTO();
                IDID.idHoaDon = sdr["idHoaDon"].ToString();
                IDID.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                IDID.idSanPham = sdr["idSanPham"].ToString();
                IDID.size = float.Parse(sdr["size"].ToString());
                IDID.soLuong = int.Parse(sdr["soLuong"].ToString());
                IDID.giaNhap = decimal.Parse(sdr["giaNhap"].ToString());
                IDID.ngayNhap = DateTime.Parse(sdr["ngayNhap"].ToString()).Date;
                ls.Add(IDID);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
