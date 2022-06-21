using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class CustomerDAO
    {
        public List<CustomerDTO> LayDanhSachKhachHang()
        {
            List<CustomerDTO> ls = new List<CustomerDTO>();
            string query = "Select * From KhachHang";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                CustomerDTO customer = new CustomerDTO();
                customer.idKhachHang = sdr["idKhachHang"].ToString();
                customer.hoTen = sdr["hoTen"].ToString();
                customer.soDienThoai = sdr["soDienThoai"].ToString();
                ls.Add(customer);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
