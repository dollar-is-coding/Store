using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDAO
{
   public class ProductDAO
    {
        public List<ProductDTO> LayDanhSachSanPham()
        {
            List<ProductDTO> lsPro = new List<ProductDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * from SanPham";
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
            while (sdr.Read())
            {
                ProductDTO sp = new ProductDTO();
                sp.idDanhMuc = sdr["idDanhMuc"].ToString();
                sp.idSanPham = sdr["idSanPham"].ToString();
                sp.tenSanPham = sdr["tenSanPham"].ToString();
                lsPro.Add(sp);
            }
            sdr.Close();
            conn.Close();
            return lsPro;
        }

        public List<ProductDTO> LayDanhSachSanPham(string idDanhMuc)
        {
            List<ProductDTO> lsPro = new List<ProductDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select *from SanPham where idDanhMuc=@idDanhMuc";
            SqlParameter par = new SqlParameter("idDanhMuc", idDanhMuc);
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, par, conn);
            while (sdr.Read())
            {
                ProductDTO sp = new ProductDTO();
                sp.idDanhMuc = sdr["idDanhMuc"].ToString();
                sp.idSanPham = sdr["idSanPham"].ToString();
                sp.tenSanPham = sdr["tenSanPham"].ToString();
                lsPro.Add(sp);
            }
            sdr.Close();
            conn.Close();
            return lsPro;
        }
        public bool LayDanhSachSanPham(string idDanhMuc, string tenSanPham)
        {
            try
            {
                string strPro = "Insert into SanPham(idDanhMuc,idSanPham,tenSanPham) values (@idDanhMuc,'',@tenSanPham)";
                SqlParameter[] parr = new SqlParameter[2];
                parr[0] = new SqlParameter("idDanhMuc", idDanhMuc);
                parr[1] = new SqlParameter("tenSanPham", tenSanPham);
                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strPro, parr, conn);
                conn.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }
    }
}
