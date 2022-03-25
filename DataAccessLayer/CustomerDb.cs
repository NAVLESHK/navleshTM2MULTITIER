using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Collections.Generic;
using CommanLayer;
//using System.Data.SqlClient;
namespace DataAccessLayer
{
       public class CustomerDb
    {
        private DbConnect db;
        public CustomerDb()
        {
           db = new DbConnect();
             }
        public List<CustomerEntity> GetCustomer()
        //public DataSet GetCustomer()
        {
            string query = "select * from customer";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            if (db.connection.State == ConnectionState.Closed)
                db.connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<CustomerEntity> customers = new List<CustomerEntity>();
            while (dr.Read())
            {
                CustomerEntity obj = new CustomerEntity();
                obj.id = (int)dr["id"];
                obj.name = dr["name"].ToString();
                obj.email = dr["email"].ToString();
                obj.mobile = dr["mobile"].ToString();
                obj.address = dr["address"].ToString();
                customers.Add(obj);
            }
            //DataSet data = (DataSet)cmd.ExecuteReader();
            db.connection.Close();
            return customers;
        }

    }
}
