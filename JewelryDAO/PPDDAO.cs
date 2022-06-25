using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class PPDDAO
    {
        public List<PPDDTO> LayDanhSachChiTietSanPham()
        {
            List<PPDDTO> ls = new List<PPDDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select SP.idSanPham,tenSanPham,idDanhMuc,size,giaBan,soLuong from SanPham SP, ChiTietSanPham CTSP where SP.idSanPham=CTSP.idSanPham and trangThai=1 and soLuong>0";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                PPDDTO PPD = new PPDDTO();
                PPD.idDanhMuc = sdr["idDanhMuc"].ToString();
                PPD.idSanPham = sdr["idSanPham"].ToString();
                PPD.tenSanPham = sdr["tenSanPham"].ToString();
                PPD.size = float.Parse(sdr["size"].ToString());
                PPD.soLuong = int.Parse(sdr["soLuong"].ToString());
                PPD.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                ls.Add(PPD);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }

        public List<PPDDTO> LayDanhSachChiTietSanPham(string idDanhMuc)
        {
            List<PPDDTO> ls = new List<PPDDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select SP.idSanPham,tenSanPham,idDanhMuc,size,giaBan,soLuong from SanPham SP, ChiTietSanPham CTSP where SP.idSanPham=CTSP.idSanPham and trangThai=1 and idDanhMuc=@idDanhMuc and soLuong>0";
            SqlParameter par = new SqlParameter("idDanhMuc", idDanhMuc);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                PPDDTO PPD = new PPDDTO();
                PPD.idDanhMuc = sdr["idDanhMuc"].ToString();
                PPD.idSanPham = sdr["idSanPham"].ToString();
                PPD.tenSanPham = sdr["tenSanPham"].ToString();
                PPD.size = float.Parse(sdr["size"].ToString());
                PPD.soLuong = int.Parse(sdr["soLuong"].ToString());
                PPD.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                ls.Add(PPD);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }

        public List<PPDDTO> LaySanPhamTheoID(string idSanPham)
        {
            List<PPDDTO> ls = new List<PPDDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select SP.idSanPham,tenSanPham,idDanhMuc,size,giaBan,soLuong from SanPham SP, ChiTietSanPham CTSP where SP.idSanPham=CTSP.idSanPham and trangThai=1 and SP.idSanPham like '%'+@idSanPham+'%'";
            SqlParameter par = new SqlParameter("idSanPham", idSanPham);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                PPDDTO PPD = new PPDDTO();
                PPD.idDanhMuc = sdr["idDanhMuc"].ToString();
                PPD.idSanPham = sdr["idSanPham"].ToString();
                PPD.tenSanPham = sdr["tenSanPham"].ToString();
                PPD.size = float.Parse(sdr["size"].ToString());
                PPD.soLuong = int.Parse(sdr["soLuong"].ToString());
                PPD.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                ls.Add(PPD);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
        
    }
}
