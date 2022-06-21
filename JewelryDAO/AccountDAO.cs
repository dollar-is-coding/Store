using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class AccountDAO
    {
        public AccountDTO TimTaiKhoan(string username)
        {
            AccountDTO account = null;
            string strTruyVan = "Select * from TaiKhoan where idTaiKhoan = @username";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter par = new SqlParameter("username", username);
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, par, connect);
            while (sdr.Read())
            {
                account = new AccountDTO();
                account.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                account.matKhau = sdr["matKhau"].ToString();
                account.hoTen = sdr["hoTen"].ToString();
                account.chucVu = sdr["chucVu"].ToString();
                account.ngaySinh = DateTime.Parse(sdr["ngaySinh"].ToString()).Date;
                account.gioiTinh = sdr["gioiTinh"].ToString();
                account.diaChi = sdr["diaChi"].ToString();
                account.soDienThoai = sdr["soDienThoai"].ToString();
                
            }
            sdr.Close();
            connect.Close();
            return account;
        }

        public List<AccountDTO> LayDanhSachTaiKhoan()
        {
            List<AccountDTO> ls = new List<AccountDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select * from TaiKhoan";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                AccountDTO account = new AccountDTO();
                account.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                account.matKhau = sdr["matKhau"].ToString();
                account.hoTen = sdr["hoTen"].ToString();
                account.chucVu = sdr["chucVu"].ToString();
                account.ngaySinh = DateTime.Parse(sdr["ngaySinh"].ToString()).Date;
                account.gioiTinh = sdr["gioiTinh"].ToString();
                account.diaChi = sdr["diaChi"].ToString();
                account.soDienThoai = sdr["soDienThoai"].ToString();
                ls.Add(account);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
    }
}
