using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDAO
{
    static public class DataProvider
    {
        static private string strKetNoi = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyBanTrangSuc;Integrated Security=True";

        static public SqlConnection TaoKetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strKetNoi);
                conn.Open();
                return conn;
            }
            catch
            {
                throw new Exception("Loi ket noi");
            }
        }
        static public SqlDataReader TruyVan(string strTruyVan, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTruyVan, conn);
                return com.ExecuteReader();
            }
            catch
            {
                throw new Exception("Loi ket noi");
            }
        }

        static public SqlDataReader TruyVan(string strTruyVan, SqlParameter par, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTruyVan, conn);
                com.Parameters.Add(par);
                return com.ExecuteReader();
            }
            catch
            {
                throw new Exception("Loi ket noi");
            }
        }
        static public SqlDataReader TruyVan(string strTruyVan, SqlParameter[] pars, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTruyVan, conn);
                com.Parameters.AddRange(pars);
                return com.ExecuteReader();
            }
            catch
            {
                throw new Exception("Loi ket noi");
            }
        }

        static public bool ThucThi(string strLenh, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strLenh, conn);
                int kq = com.ExecuteNonQuery();
                if (kq > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw new Exception("Loi ket noi");
            }
        }
        static public bool ThucThi(string strLenh, SqlParameter[] pars, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strLenh, conn);
                com.Parameters.AddRange(pars);
                int kq = com.ExecuteNonQuery();
                if (kq > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw new Exception("Loi ket noi");
            }
        }

        static public bool ThucThi(string strLenh, SqlParameter par, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strLenh, conn);
                com.Parameters.Add(par);
                int kq = com.ExecuteNonQuery();
                if (kq > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw new Exception("Loi ket noi");
            }
        }
    }
}
