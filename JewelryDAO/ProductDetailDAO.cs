using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class ProductDetailDAO
    {
        public List<ProductDetailDTO> LayDanhSachKichCo(string idSanPham)
        {
            List<ProductDetailDTO> ls = new List<ProductDetailDTO>();
            string query = "Select * from ChiTietSanPham where idSanPham = @idSanPham and trangThai = 1";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter par = new SqlParameter("idSanPham", idSanPham);
            SqlDataReader sdr = DataProvider.TruyVan(query, par, connect);
            while (sdr.Read())
            {
                ProductDetailDTO PD = new ProductDetailDTO();
                PD.idSanPham = sdr["idSanPham"].ToString();
                PD.size = float.Parse(sdr["size"].ToString());
                PD.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                PD.soLuong = int.Parse(sdr["soLuong"].ToString());
                ls.Add(PD);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
