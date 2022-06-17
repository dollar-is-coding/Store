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
            string strTruyVan = "Select * from TaiKhoan where trangThai = 1 and idTaiKhoan = @username";
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
                account.ngaySinh = sdr["ngaySinh"].ToString();
                account.gioiTinh = sdr["gioiTinh"].ToString();
                account.diaChi = sdr["diaChi"].ToString();
                account.soDienThoai = sdr["soDienThoai"].ToString();
                account.trangThai = int.Parse(sdr["trangThai"].ToString());
            }
            sdr.Close();
            connect.Close();
            return account;
        }
    }
}
