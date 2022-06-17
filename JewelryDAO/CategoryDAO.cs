using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class CategoryDAO
    {
        public List<CategoryDTO> LayDanhSachDanhMuc()
        {
            List<CategoryDTO> categoryLs = new List<CategoryDTO>();
            string strTruyVan = "Select * From DanhMuc";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, connect);
            while (sdr.Read())
            {
                CategoryDTO category = new CategoryDTO();
                category.idDanhMuc = sdr["idDanhMuc"].ToString();
                category.tenDanhMuc = sdr["tenDanhMuc"].ToString();
                categoryLs.Add(category);
            }
            sdr.Close();
            connect.Close();
            return categoryLs;
        }
    }
}
