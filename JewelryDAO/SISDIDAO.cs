using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDAO
{
    public class SISDIDAO
    {
        public List<SISDIDTO> LayDanhSachCTHDBanHang()
        {
            List<SISDIDTO> ls = new List<SISDIDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "select hd.idHoaDon,idCTHD,kh.idKhachHang,idTaiKhoan,kh.hoTen,ctsp.idSanPham,cthd.size,giaBan,cthd.soLuong,ngayBan from HDBanHang hd ,CTHDBanHang cthd ,ChiTietSanPham ctsp, KhachHang kh where hd.idHoaDon = cthd.idHoaDon and cthd.idSanPham = ctsp.idSanPham and cthd.size =ctsp.size and hd.idKhachHang=kh.idKhachHang";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                SISDIDTO SISD = new SISDIDTO();
                SISD.idHoaDon = sdr["idHoaDon"].ToString();
                SISD.idCTHD = sdr["idCTHD"].ToString();
                SISD.idKhachHang = sdr["idKhachHang"].ToString();
                SISD.hoTen = sdr["hoTen"].ToString();
                SISD.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                SISD.idSanPham = sdr["idSanPham"].ToString();
                SISD.size = float.Parse(sdr["size"].ToString());
                SISD.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                SISD.soLuong = int.Parse(sdr["soLuong"].ToString());
                SISD.ngayBan = DateTime.Parse(sdr["ngayBan"].ToString()).Date;
                ls.Add(SISD);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }

        public List<SISDIDTO> LayDanhSachCTHDBanHang(string idHoaDon)
        {
            List<SISDIDTO> ls = new List<SISDIDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "select hd.idHoaDon,idCTHD,kh.idKhachHang,idTaiKhoan,kh.hoTen,ctsp.idSanPham,cthd.size,giaBan,cthd.soLuong,ngayBan from HDBanHang hd ,CTHDBanHang cthd ,ChiTietSanPham ctsp, KhachHang kh where hd.idHoaDon = cthd.idHoaDon and cthd.idSanPham = ctsp.idSanPham and cthd.size =ctsp.size and hd.idKhachHang=kh.idKhachHang and hd.idHoaDon=@idHoaDon";
            SqlParameter par = new SqlParameter("idHoaDon", idHoaDon);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                SISDIDTO SISD = new SISDIDTO();
                SISD.idHoaDon = sdr["idHoaDon"].ToString();
                SISD.idCTHD = sdr["idCTHD"].ToString();
                SISD.idKhachHang = sdr["idKhachHang"].ToString();
                SISD.hoTen = sdr["hoTen"].ToString();
                SISD.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                SISD.idSanPham = sdr["idSanPham"].ToString();
                SISD.size = float.Parse(sdr["size"].ToString());
                SISD.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                SISD.soLuong = int.Parse(sdr["soLuong"].ToString());
                SISD.ngayBan = DateTime.Parse(sdr["ngayBan"].ToString()).Date;
                ls.Add(SISD);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }

        public List<SISDIDTO> LayCTSPTheoHDBHLonNhat(string idHoaDon)
        {
            List<SISDIDTO> ls = new List<SISDIDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "select hd.idHoaDon,idCTHD,idKhachHang,idTaiKhoan,ctsp.idSanPham,cthd.size,giaBan,cthd.soLuong,ngayBan from HDBanHang hd ,CTHDBanHang cthd ,ChiTietSanPham ctsp where hd.idHoaDon = cthd.idHoaDon and cthd.idSanPham = ctsp.idSanPham and cthd.size =ctsp.size and hd.idHoaDon=@idHoaDon";
            SqlParameter par = new SqlParameter("idHoaDon", idHoaDon);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                SISDIDTO SISD = new SISDIDTO();
                SISD.idHoaDon = sdr["idHoaDon"].ToString();
                SISD.idCTHD = sdr["idCTHD"].ToString();
                SISD.idKhachHang = sdr["idKhachHang"].ToString();
                SISD.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                SISD.idSanPham = sdr["idSanPham"].ToString();
                SISD.size = float.Parse(sdr["size"].ToString());
                SISD.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                SISD.soLuong = int.Parse(sdr["soLuong"].ToString());
                SISD.ngayBan = DateTime.Parse(sdr["ngayBan"].ToString()).Date;
                ls.Add(SISD);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
