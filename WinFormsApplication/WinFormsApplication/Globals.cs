﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form
{
	public class DB
	{
		public static string Connection_String()
		{
			
			return @"Data Source=ADIR\SQLEXPRESS;Initial Catalog=TEST;User Id=Team;password=1234;TrustServerCertificate=True;";
		}

        public static string GenarateHash(int length = 20)
        {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];



                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
            return res.ToString();
        }

        public class Get
		{
			public static bool LoginAuth(string email, string password)
			{

				using (SqlConnection con = new SqlConnection(DB.Connection_String()))
				{
					using (SqlCommand cmd = new SqlCommand("SELECT  * FROM [TEST].[dbo].[UserDetails] where [Email]='" + email + "' and [Password]='" + password + "'", con))
					{
						con.Open();

						SqlDataReader sdr = cmd.ExecuteReader();
						
						if (sdr.Read())
						{
							con.Close();
							return true;
						}
						else
						{
							con.Close();
							return false;
						}
					}

				}
			}

            //Register 

            public static void Register(string Name, string Email, string Password,string Phone )
            {
                using (SqlConnection connec = new SqlConnection(DB.Connection_String()))
                {

                    using (SqlCommand cmd = new SqlCommand("InsertNewUserDetails", connec))
                    {

                        connec.Open();

                        cmd.CommandType = CommandType.StoredProcedure;





                        cmd.Parameters.AddWithValue("@ID", DateTime.Now.ToString("ddMMyyyyhhmmssfff"));
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                       



                        cmd.ExecuteNonQuery();
                        // ID = cmd.ExecuteScalar().ToString();

                        connec.Close();

                    }

                }
            }
        }



	}
}

