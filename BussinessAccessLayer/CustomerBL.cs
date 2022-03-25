using System.Collections.Generic;
using CommanLayer;
using DataAccessLayer;

namespace BussinessAccessLayer
{
    public class CustomerBL
    {
         private CustomerDb customerDb;
        public CustomerBL()
        {
            customerDb = new CustomerDb();
        }
        public List<CustomerEntity> GetCustomer()
        {
            var customers = customerDb.GetCustomer();
            return customers;
        }
        
    }
}
