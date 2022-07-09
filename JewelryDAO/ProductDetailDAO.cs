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

        public bool ThemMotChiTietSanPhamMoi(ProductDetailDTO DP)
        {
            string query = "select * from ChiTietSanPham where idSanPham = @idSanPham and size = @size";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("idSanPham", DP.idSanPham);
            pars[1] = new SqlParameter("size", DP.size);
            bool kq = DataProvider.KiemTraTruyVan(query, pars, connect);
            if (kq == true)
            {
                try
                {
                    string strupdate = "update ChiTietSanPham set giaban=@giaBan, soluong+=@soLuong where idsanpham = @idSanPham and size = @size";
                    SqlParameter[] pars2 = new SqlParameter[4];
                    pars2[0] = new SqlParameter("giaBan", DP.giaBan);
                    pars2[1] = new SqlParameter("soLuong", DP.soLuong);
                    pars2[2] = new SqlParameter("idSanPham", DP.idSanPham);
                    pars2[3] = new SqlParameter("size", DP.size);
                    bool update = DataProvider.ThucThi(strupdate, pars2, connect);
                    connect.Close();
                    return update;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    string strinsert = "insert into ChiTietSanPham values (@idSanPham,@size,@giaBan,@soLuong,1)";
                    SqlParameter[] pars3 = new SqlParameter[4];
                    pars3[0] = new SqlParameter("idSanPham", DP.idSanPham);
                    pars3[1] = new SqlParameter("size", DP.size);
                    pars3[2] = new SqlParameter("giaBan", DP.giaBan);
                    pars3[3] = new SqlParameter("soLuong", DP.soLuong);
                    bool insert = DataProvider.ThucThi(strinsert, pars3, connect);
                    connect.Close();
                    return insert;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool CapNhatChiTietSanPham(ProductDetailDTO PD)
        {
            try
            {
                string update = "Update ChiTietSanPham set soLuong-=@soLuong where idSanPham=@idSanPham and size=@size";
                SqlConnection connect = DataProvider.TaoKetNoi();
                SqlParameter[] pars = new SqlParameter[3];
                pars[0] = new SqlParameter("soLuong", PD.soLuong);
                pars[1] = new SqlParameter("idSanPham", PD.idSanPham);
                pars[2] = new SqlParameter("size", PD.size);
                bool kq = DataProvider.ThucThi(update, pars, connect);
                connect.Close();
                return kq;
            }
            catch 
            {
                return false;
            }
        }
    }
}
