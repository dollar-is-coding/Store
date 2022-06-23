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
                account.ngaySinh = sdr["ngaySinh"].ToString();
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
                account.ngaySinh = sdr["ngaySinh"].ToString();
                account.gioiTinh = sdr["gioiTinh"].ToString();
                account.diaChi = sdr["diaChi"].ToString();
                account.soDienThoai = sdr["soDienThoai"].ToString();
                ls.Add(account);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
        public bool ThemTaiKhoanMoi(AccountDTO acc)
        {
            try
            {
                string strIns = "Insert into TaiKhoan values (@idTaiKhoan,@matKhau,@hoTen,@chucVu,@ngaySinh,@gioiTinh,@diaChi,@soDienThoai)";
                SqlParameter[] arr = new SqlParameter[8];
                arr[0] = new SqlParameter("idTaiKhoan", acc.idTaiKhoan);
                arr[1] = new SqlParameter("matKhau", acc.matKhau);
                arr[2] = new SqlParameter("hoTen", acc.hoTen);
                arr[3] = new SqlParameter("chucVu", acc.chucVu);
                arr[4] = new SqlParameter("ngaySinh", acc.ngaySinh);
                arr[5] = new SqlParameter("gioiTinh", acc.gioiTinh);
                arr[6] = new SqlParameter("diaChi", acc.diaChi);
                arr[7] = new SqlParameter("soDienThoai", acc.soDienThoai);

                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strIns, arr, conn);
                conn.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }
        public bool CapNhatTaiKhoan(AccountDTO acc)
        {
            try
            {
                string strUp = "Update TaiKhoan set matKhau=@matKhau, hoTen=@hoTen, chucVu=@chucVu, ngaySinh=@ngaySinh, gioiTinh=@gioiTinh, diaChi=@diaChi, soDienThoai=@soDienThoai where idTaiKhoan=@idTaiKhoan";
                SqlParameter[] arr = new SqlParameter[8];
                arr[0] = new SqlParameter("idTaiKhoan", acc.idTaiKhoan);
                arr[1] = new SqlParameter("matKhau", acc.matKhau);
                arr[2] = new SqlParameter("hoTen", acc.hoTen);
                arr[3] = new SqlParameter("chucVu", acc.chucVu);
                arr[4] = new SqlParameter("ngaySinh", acc.ngaySinh);
                arr[5] = new SqlParameter("gioiTinh", acc.gioiTinh);
                arr[6] = new SqlParameter("diaChi", acc.diaChi);
                arr[7] = new SqlParameter("soDienThoai", acc.soDienThoai);

                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strUp, arr, conn);
                conn.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }
        //public bool XoaTaiKhoan(string idTaiKhoan)
        //{
        //    try
        //    {
        //        string strDel = "update TaiKhoan set trangThai=0 where idTaiKhoan=@idTaiKhoan";
        //        SqlParameter arr = new SqlParameter();
        //        arr = new SqlParameter("idTaiKhoan", idTaiKhoan);
        //        SqlConnection conn = DataProvider.TaoKetNoi();
        //        bool kq = DataProvider.ThucThi(strDel, arr, conn);
        //        conn.Close();
        //        return kq;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
