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

        public CustomerDTO LayIDKhachHang(string hoTen,string soDienThoai)
        {
            CustomerDTO customer = null;
            string query = "Select * From KhachHang where hoTen=@hoTen and soDienThoai=@soDienThoai";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("hoTen", hoTen);
            pars[1] = new SqlParameter("soDienThoai", soDienThoai);
            SqlDataReader sdr = DataProvider.TruyVan(query,pars, connect);
            while (sdr.Read())
            {
                customer = new CustomerDTO();
                customer.idKhachHang = sdr["idKhachHang"].ToString();
                customer.hoTen = sdr["hoTen"].ToString();
                customer.soDienThoai = sdr["soDienThoai"].ToString();
               
            }
            sdr.Close();
            connect.Close();
            return customer;
        }
        public bool ThemMotKhachHang(CustomerDTO kh)
        {
            string Qury = "select *from KhachHang where hoTen=@hoTen and soDienThoai=@soDienThoai";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlParameter[] parr = new SqlParameter[2];
            parr[0] = new SqlParameter("hoTen", kh.hoTen);
            parr[1] = new SqlParameter("soDienThoai", kh.soDienThoai);
            bool kq = DataProvider.KiemTraTruyVan(Qury, parr, conn);
            if(kq!=true)
            {
                try
                {
                    string Ins = "Insert into KhachHang values ('',@hoTen,@soDienThoai)";
                    SqlParameter[] par1 = new SqlParameter[2];
                    par1[0] = new SqlParameter("hoten", kh.hoTen);
                    par1[1] = new SqlParameter("soDienThoai", kh.soDienThoai);
                    bool insert = DataProvider.ThucThi(Ins, par1, conn);
                    return insert;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
