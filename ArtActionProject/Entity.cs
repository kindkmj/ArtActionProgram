using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtActionProject
{
    public static class Entity
    {
        static SqlConnection conn;
        static string dbInfo = @"Server=192.168.0.230\MSSQLSERVER,1433; database=customerinfo;uid=st;pwd=dkdlxl";
      
        //연결
        public static SqlConnection CreateAndOpenConnection()
        {
            conn = new SqlConnection(dbInfo);
            conn.Open();
            return conn;
        }

        public static bool DmlCase(string processCase, string ID, string PW, string Email, string CardNumber=null)
        {
            //insert
            if (processCase == "I")
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = CreateAndOpenConnection();
                    cmd.CommandText = $"insert into customer(ID,PW,EMAIL,CARD_NUMBER) values ('{ID}','{PW}','{Email}','{CardNumber}')";
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            else if (processCase == "U") //update
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                }
            }

            return true;
        }

        public static string Select(string processCase,string ID, string PW, string Email, string CardNumber = null)
        {
            string result = "";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CreateAndOpenConnection();
                cmd.CommandText = $"select ID,EMAIL from customer where id='{ID}'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (processCase == "ID")
                {
                    while (reader.Read())
                    {
                        result = reader["ID"] as string;
                    }
                }
                else if (processCase == "PW")
                {
                    while (reader.Read())
                    {
                        result = reader["PW"] as string;
                    }
                }

                reader.Close();
            }
            return result;
        }
        public static string Select(string processCase, string ID)
        {
            string result = "";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CreateAndOpenConnection();
                cmd.CommandText = $"select ID,EMAIL from customer where id='{ID}'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (processCase == "ID")
                {
                    while (reader.Read())
                    {
                        result = reader["ID"] as string;
                    }
                }
                else if (processCase == "PW")
                {
                    while (reader.Read())
                    {
                        result = reader["PW"] as string;
                    }
                }
                else if (processCase == "EMAIL")
                {
                    while (reader.Read())
                    {
                        result = reader["EMAIL"] as string;
                    }
                }

                reader.Close();
            }
            return result;
        }

        //INSERT
        //        public void Insert(string ID, string PW, string Email, string CardNumber)
        //        {
        //            try
        //            {
        //
        //                using (SqlCommand cmd = new SqlCommand())
        //                {
        //                    if (ID != null || PW != null || Email != null)
        //                    {
        //                        cmd.Connection = conn;
        //                        cmd.CommandText = @"INSERT INTO HumanTable" + "\r\n" +
        //                                          @"VALUES(@ID, @PW, @EMAIL, @CardNumber)";
        ////                        cmd.Parameters.AddWithValue("@ID", ID);
        ////                        cmd.Parameters.AddWithValue("@PW", PW);
        ////                        cmd.Parameters.AddWithValue("@EMAIL", Email);
        ////                        cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
        //
        //                        cmd.Connection = conn;
        //                        int nRun = cmd.ExecuteNonQuery();
        //                    }
        //                    else 
        //                    {
        //                        Console.WriteLine("아이디가 입력되지 않았습니다.");
        //                    }
        //                }
        //            }
        //            catch(Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //
        //        //SELECT
        //        
        //        public void Select(string ID, string PW)
        //        {
        //            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CustomerInfo where ID ='" + ID + "' AND PW ='" + PW + "'", conn);
        //            DataTable newTable = new DataTable();
        //
        //            sda.Fill(newTable);
        //
        //            if(ID == null)
        //            {
        //                Console.WriteLine("아이디를 입력해주세요");
        //            }
        //            else
        //            {
        //                if(newTable.Rows[0][0].ToString() == "1")
        //                {
        //                    Console.WriteLine("로그인에 성공하셨습니다");
        //                }
        //
        //                else
        //                {
        //                    Console.WriteLine("로그인에 실패하셨습니다.");
        //                }
        //            }
        //            
        //
        //        }
        //
        //        //UPDATE
        //        public void Update()
        //        {
        //
        //        }
    }     
}
