using Microsoft.AspNetCore.Mvc;
using BussinessAccessLayer;
using CommanLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TM2MULTITIER.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerBL customerBL;
        public CustomerController()
        {
            customerBL = new CustomerBL();
        }
        public IActionResult Index()
        {
            var customer = customerBL.GetCustomer();
            return View(customer);
        }
    }
}
