using System;
//using System.Data.SqlClient;
using ConfigFramework;
using Microsoft.Data.SqlClient;
namespace DataAccessLayer
{
    public class DbConnect
    {
        public SqlConnection connection;
       public  DbConnect()
        {
            connection = new SqlConnection(DbConfig.ConnectionString);
        }

    }
}
