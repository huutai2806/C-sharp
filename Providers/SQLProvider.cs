using RegisterAndLogin.DataTransfer;
using RegisterAndLogin.Models;
using System;
using System.Data.SqlClient;

namespace RegisterAndLogin.Providers
{
    public static class SQLProvider
    {
        private static readonly string connetionString = @"Data Source=DESKTOP-05H76AP\MSSQLSERVER01;Initial Catalog=StudentDB;User ID=sa;Password=Tai280603";
        public static int Login(UserLogin userLogin, out string messageLogin) 
        {
            User user = GetUser(userLogin.Username);
            if (user == null) 
            {
                messageLogin = "Sai tai khoan";
                return -1;
            }
            if (user.Password == userLogin.Password) 
            {
                messageLogin = "Dang nhap thanh cong";
                return 1;
            }

            messageLogin = "Sai mat khau";
            return -2;
        }

        public static User GetUser(string username) 
        {
            User user = new User();
            try
            {
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    string sql = "select * from [User] where Account = @username";
                    SqlCommand oCmd = new SqlCommand(sql, cnn);
                    oCmd.Parameters.AddWithValue("@username", username);
                    cnn.Open();

                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            user.Account = oReader["Account"].ToString();
                            user.Password = oReader["Password"].ToString();
                        }

                        cnn.Close();
                    }

                    user.Message = "Successfully !";
                }
            }
            catch (Exception e)
            {
                user.Message = e.Message;
                return user;
            }


            return user;
        }

        public static User GetUser(string username, out string message)
        {
            message = string.Empty;
            User user = new User();
            try
            {
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    string sql = "select * from [User] where Account = @username";
                    SqlCommand oCmd = new SqlCommand(sql, cnn);
                    oCmd.Parameters.AddWithValue("@username", username);
                    cnn.Open();

                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            user.Account = oReader["Account"].ToString();
                            user.Password = oReader["Password"].ToString();
                        }

                        cnn.Close();
                    }
                    message = "Successfully";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }

            return user;
        }
    }
}
