using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class Product4ReportDAO
    {
        public List<Product4ReportDTO> LayDanhSachChiTietSanPham()
        {
            List<Product4ReportDTO> ls = new List<Product4ReportDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select SP.idSanPham,tenSanPham,DM.idDanhMuc,tenDanhMuc,size,giaBan,soLuong from SanPham SP, ChiTietSanPham CTSP, DanhMuc DM where SP.idSanPham=CTSP.idSanPham and SP.idDanhMuc=DM.idDanhMuc and trangThai=1 and soLuong>0";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                Product4ReportDTO P4R = new Product4ReportDTO();
                P4R.idDanhMuc = sdr["idDanhMuc"].ToString();
                P4R.tenDanhMuc = sdr["tenDanhMuc"].ToString();
                P4R.idSanPham = sdr["idSanPham"].ToString();
                P4R.tenSanPham = sdr["tenSanPham"].ToString();
                P4R.size = float.Parse(sdr["size"].ToString());
                P4R.soLuong = int.Parse(sdr["soLuong"].ToString());
                P4R.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                ls.Add(P4R);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
        public List<Product4ReportDTO> LayDanhSachChiTietSanPham(string tenDanhMuc)
        {
            List<Product4ReportDTO> ls = new List<Product4ReportDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select SP.idSanPham,tenSanPham,tenDanhMuc,size,giaBan,soLuong from SanPham SP, ChiTietSanPham CTSP, DanhMuc DM where SP.idSanPham=CTSP.idSanPham and SP.idDanhMuc=DM.idDanhMuc and trangThai=1 and soLuong>0 and tenDanhMuc=@tenDanhMuc";
            SqlParameter par = new SqlParameter("tenDanhMuc", tenDanhMuc);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                Product4ReportDTO P4R = new Product4ReportDTO();
                P4R.tenDanhMuc = sdr["tenDanhMuc"].ToString();
                P4R.idSanPham = sdr["idSanPham"].ToString();
                P4R.tenSanPham = sdr["tenSanPham"].ToString();
                P4R.size = float.Parse(sdr["size"].ToString());
                P4R.soLuong = int.Parse(sdr["soLuong"].ToString());
                P4R.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                ls.Add(P4R);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
