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
            string strTruyVan = "Select *from SanPham";
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
    }
}
