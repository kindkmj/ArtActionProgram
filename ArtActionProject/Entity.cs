using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtActionProject
{
    class Entity
    {
        SqlConnection conn;
        string dbInfo = @"Server=192.168.0.230\MSSQLSERVER.1433; database=customerinfo;uid=st;pwd=dkdlxl";




        //연결
        public void CreateAndOpenConnection()
        {
            conn = new SqlConnection(dbInfo);
            conn.Open();
            Console.WriteLine("연결에 성공하셨습니다");
        }

        //INSERT
        public void Insert(string ID, string PW, string Email, string CardNumber)
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    if (ID != null || PW != null || Email != null)
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"INSERT INTO HumanTable" + "\r\n" +
                                          @"VALUES(@ID, @PW, @EMAIL, @CardNumber)";
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@PW", PW);
                        cmd.Parameters.AddWithValue("@EMAIL", Email);
                        cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                        cmd.Connection = conn;
                        int nRun = cmd.ExecuteNonQuery();
                    }
                    else 
                    {
                        Console.WriteLine("아이디가 입력되지 않았습니다.");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //SELECT
        
        public void Select(string ID, string PW)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CustomerInfo where ID ='" + ID + "' AND PW ='" + PW + "'", conn);
            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if(ID == null)
            {
                Console.WriteLine("아이디를 입력해주세요");
            }
            else
            {
                if(newTable.Rows[0][0].ToString() == "1")
                {
                    Console.WriteLine("로그인에 성공하셨습니다");
                }

                else
                {
                    Console.WriteLine("로그인에 실패하셨습니다.");
                }
            }
            

        }

        //UPDATE
        public void Update()
        {

        }
    }     
}
