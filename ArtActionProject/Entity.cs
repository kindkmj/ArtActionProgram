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
        // 옥션관련
        // insert - 유저가 방 참여시
        // update - 옥션이 종료 될경우
        // select - 어떤 유저가 제일 높은 가격을 가지고 있는지 확인할 경우
        // delete - x
        private const string ACTION = "A";
        //

        // 상품 관련
        // insert - x
        // update - 매니저가 방 등록시
        // select - x
        // delete - x
        private const string PRODUCTSELECTION = "PS";
        //

        // 사용자 관련
        // insert - 회원가입
        // update - 옥션에서 물품 낙찰 받을때
        // select - 회원 정보 확인,아이디확인,패스워드 확인,이메일 찾기,로그인
        private const string CUSTOMERINFO = "C";
        private const string REGISTER = "R";
        private const string FINDINGID = "FI";
        private const string FINDEMAIL = "FE";
        private const string FINDSELECT = "S";
        private const string FINDPW = "FP";
        //

        static SqlConnection conn;
        static string dbInfo = @"Server=192.168.0.230\MSSQLSERVER,1433; database=AUCTION_DB;uid=st;pwd=dkdlxl";
      
        //연결
        public static SqlConnection CreateAndOpenConnection()
        {
            conn = new SqlConnection(dbInfo);
            conn.Open();
            return conn;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="processCase"></param>
        /// <description>INSERT 인지 UPDATE인지 선택</description>
        /// <param name="tableName"></param>
        /// <description>해당 테이블 이름 </description>
        /// <param name="COLUMN_DATA0"></param>
        /// <description>변경 혹은 추가하고자 하는 컬럼이름,업데이트일 경우 변경하고자하는 컬럼</description>
        /// <param name="COLUMN_DATA1"></param>
        /// <description>변경 혹은 추가하고자 하는 컬럼이름,업데이트일 경우 변경될 값</description>
        /// <param name="COLUMN_DATA2"></param>
        /// <description>변경 혹은 추가하고자 하는 컬럼이름, 조건이 될 컬럼</description>
        /// <param name="COLUMN_DATA3"></param>
        /// <description>추가할 값 입력,조건이 될 값</description>
        /// <param name="COLUMN_DATA4"></param>
        /// <description>추가할 값 입력</description>
        /// <param name="COLUMN_DATA5"></param>
        /// <description>추가할 값 입력</description>
        /// <returns></returns>
        public static bool DmlCase(string processCase, string tableName, string COLUMN_DATA0,
            string COLUMN_DATA1, string COLUMN_DATA2=null, string COLUMN_DATA3 = null,string COLUMN_DATA4=null,string COLUMN_DATA5=null)
        {
            //insert
                if (processCase == "I")
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = CreateAndOpenConnection();
                        cmd.CommandText =
                            $"insert into {tableName} ({COLUMN_DATA0},{COLUMN_DATA1},{COLUMN_DATA2}) values ('{COLUMN_DATA3}','{COLUMN_DATA4}','{COLUMN_DATA5}')";
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                else if (processCase == "U") //update
                {
                    //UPDATE [테이블] SET [열] = '변경할값' WHERE [조건]
                    //update auction set CONFIRMED_AMOUNT = '150' where user_name = 'kmj'
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = CreateAndOpenConnection();
                        cmd.CommandText =
                            $"Update {tableName} set  {COLUMN_DATA0} ='{COLUMN_DATA1}' where {COLUMN_DATA2} ='{COLUMN_DATA3}'";
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
//                else if (processCase == "D")
//                {
//                    using (SqlCommand cmd = new SqlCommand())
//                    {
//                        cmd.Connection = CreateAndOpenConnection();
//                        cmd.CommandText =
//                            $"delete into customer(ID,PW,EMAIL,CARD_NUMBER) values ('{ID}','{PW}','{Email}','{CardNumber}')";
//                        cmd.ExecuteNonQuery();
//                        return true;
//                    }
//                }
//            else if (talbeState == PRODUCTSELECTION)
//            {
//                if (processCase == "U") //update
//                {
//                    //UPDATE [테이블] SET [열] = '변경할값' WHERE [조건]
//                    using (SqlCommand cmd = new SqlCommand())
//                    {
//                        cmd.Connection = CreateAndOpenConnection();
//                        cmd.CommandText =
//                            $"Update '{tableName}' set  {COLUMN_DATA0} ='{COLUMN_DATA1}' where {COLUMN_DATA2} ='{COLUMN_DATA3}'";
//                        cmd.ExecuteNonQuery();
//                        return true;
//                    }
//                }
//                else if (processCase == "I")
//                {
//                    using (SqlCommand cmd = new SqlCommand())
//                    {
//                        cmd.Connection = CreateAndOpenConnection();
//                        cmd.CommandText =
//                            $"insert into '{tableName}'({COLUMN_DATA0},{COLUMN_DATA1},{COLUMN_DATA2}) values ('{COLUMN_DATA3}','{COLUMN_DATA4}','{COLUMN_DATA5}')";
//                        cmd.ExecuteNonQuery();
//                        return true;
//                    }
//                }
//            }
            return true;
        }

        public static bool DmlCase1(string processCase, string tableName, string COLUMN_DATA0,
           int COLUMN_DATA1, string COLUMN_DATA2 = null, string COLUMN_DATA3 = null, string COLUMN_DATA4 = null, string COLUMN_DATA5 = null)
        {
            //insert
            if (processCase == "I")
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = CreateAndOpenConnection();
                    cmd.CommandText =
                        $"insert into {tableName} ({COLUMN_DATA0},{COLUMN_DATA1},{COLUMN_DATA2}) values ('{COLUMN_DATA3}','{COLUMN_DATA4}','{COLUMN_DATA5}')";
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            else if (processCase == "U") //update
            {
                //UPDATE [테이블] SET [열] = '변경할값' WHERE [조건]
                //update auction set CONFIRMED_AMOUNT = '150' where user_name = 'kmj'
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = CreateAndOpenConnection();
                    cmd.CommandText =
                        $"Update {tableName} set  {COLUMN_DATA0} ='{COLUMN_DATA1}' where {COLUMN_DATA2} ='{COLUMN_DATA3}'";
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            return true;
        }



            /// <summary>
            /// 
            /// </summary>
            /// <param name="tableState"></param>
            /// <description>테이블 타입 입력 </description>
            /// <param name="processCase"></param>
            /// <description>어떤 경우인지 케이스 입력</description>
            /// <param name="COLUMN_DATA0"></param>
            /// <description>검색할 데이터 종류 입력 </description>
            /// <param name="COLUMN_DATA1"></param>
            /// <description>검색할 테이블 이름 입력 tablestatue와 겹치므로 추후 수정 예정사항 </description>
            /// <param name="COLUMN_DATA2"></param>
            /// <description>검색할 컬럼명</description>
            /// <param name="COLUMN_DATA3"></param>
            /// <description>검색할 데이터</description>
            /// <returns></returns>
            public static string Select(string tableState,string processCase,string COLUMN_DATA0=null, string COLUMN_DATA1 = null,string COLUMN_DATA2= null, string COLUMN_DATA3 = null)
        {
            string result = "";
            using (SqlCommand cmd = new SqlCommand())
            {
                    cmd.Connection = CreateAndOpenConnection();
                if (tableState == CUSTOMERINFO)
                {
                    if (processCase == FINDSELECT)
                    {
                        //test =Entity.Select("C", "S", "ID", "CUSTOMER_INFO", "ID", tbIDRegisterForm.Text.Trim());  
                        cmd.CommandText = $"select {COLUMN_DATA0} from {COLUMN_DATA1} where {COLUMN_DATA2}='{COLUMN_DATA3}'";
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            result = reader[$"{COLUMN_DATA0}"] as string;
                        }
                        reader.Close();
                    }
//                    else if (processCase == FINDPW)
//                    {
//                        cmd.CommandText = $"select {COLUMN_DATA0} from {COLUMN_DATA1} where {COLUMN_DATA2}='{COLUMN_DATA3}'";
//                        SqlDataReader reader = cmd.ExecuteReader();
//                        while (reader.Read())
//                        {
//                            result = reader[$"{COLUMN_DATA0}"] as string;
//                        }
//                        reader.Close();
//                    }
//                    else if (processCase == FINDINGID)
//                    {
//                        cmd.CommandText = $"select ID from customer where id='{infoState}'";
//                        SqlDataReader reader = cmd.ExecuteReader();
//                        while (reader.Read())
//                        {
//                            result = reader["ID"] as string;
//                        }
//                        reader.Close();
//                    }
                }
            }
            return result;
        }

        public static void Delete(string tableState,string COLUMN_DATA0 =null,string COLUMN_DATA1= null)
        {
            try
            {
                string result = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = CreateAndOpenConnection();


                    cmd.CommandText = $"DELETE FROM {tableState} WHERE {COLUMN_DATA0} = '{COLUMN_DATA1}'";
                    // $"insert into {tableName} ({COLUMN_DATA0},{COLUMN_DATA1},{COLUMN_DATA2}) values ('{COLUMN_DATA3}','{COLUMN_DATA4}','{COLUMN_DATA5}')";
                    //cmd.Parameters.AddWithValue($"{COLUMN_DATA0}={COLUMN_DATA1}");
                    int nRun = cmd.ExecuteNonQuery();

                    //cmd.ExecuteNonQuery();


                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        public static void Select(String COLUMN_DATA0,String COLUMN_DATA1,String COLUMN_DATA2)
        {

            try
            {
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = $"SELECT USER_NAME,CONFIRMED_AMOUNT FROM AUCTION";
                //int nRun = cmd.ExecuteNonQuery();

                string result = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = CreateAndOpenConnection();


                    cmd.CommandText = $"select {COLUMN_DATA0},{COLUMN_DATA1} from {COLUMN_DATA2}";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result = reader[$"{COLUMN_DATA0}:{COLUMN_DATA1}"] as string;
                    }
                    reader.Close();




                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




    }     
}
