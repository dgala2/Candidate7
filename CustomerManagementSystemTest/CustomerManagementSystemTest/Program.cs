using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemTest.Domain;
using CustomerManagementSystemTest.Repository;

namespace CustomerManagementSystemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // I would have liked to add Dependency Injection
            // By registering services to the IOC container
            // And added a test project as well using UNit Adapter
            // Due to shortage of time - I am sticking to a few basics

            var customerManagementBl = new CustomerManagementBl(new CustomerDetailsRepository());
            customerManagementBl.DisplayStatistics();
        }
    }
}
