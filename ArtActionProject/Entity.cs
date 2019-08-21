using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtActionProject
{
    class Entity
    {
        static void Main(string[] args)
        {
            Select();
        }

        private static void Select()
        {
            SqlConnection connection = createAndOpenConnection();

            SqlCommand command = CreateCommand();
        }

        private static SqlCommand CreateCommand(string commanText, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commanText;
            command.CommandType = commandType 
        }

        private static SqlConnection createAndOpenConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"DB 데이터 주소를 입력";
            connection.Open();

            return connection;
        }
    }
}
