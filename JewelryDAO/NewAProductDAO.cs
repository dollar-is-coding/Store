using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class NewAProductDAO
    {
        public List<NewAProductDTO> LayDanhSachThemSanPham()
        {
            List<NewAProductDTO> ls = new List<NewAProductDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select idHoaDon,SP.idDanhMuc,CTSP.idSanPham,SP.tenSanPham,CTSP.size,CTSP.soLuong,CTHD.giaNhap,CTSP.giaBan from CTHDNhapHang CTHD, ChiTietSanPham CTSP, SanPham SP where CTSP.idSanPham=SP.idSanPham and CTHD.idSanPham=CTSP.idSanPham and CTHD.size=CTSP.size";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                NewAProductDTO aNew = new NewAProductDTO();
                aNew.idHoaDon = sdr["idHoaDon"].ToString();
                aNew.idDanhMuc = sdr["idDanhMuc"].ToString();
                aNew.idSanPham = sdr["idSanPham"].ToString();
                aNew.tenSanPham = sdr["tenSanPham"].ToString();
                aNew.size = float.Parse(sdr["size"].ToString());
                aNew.soLuong = int.Parse(sdr["soLuong"].ToString());
                aNew.giaNhap = decimal.Parse(sdr["giaNhap"].ToString());
                aNew.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                ls.Add(aNew);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
