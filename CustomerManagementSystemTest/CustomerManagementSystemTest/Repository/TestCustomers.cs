using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemTest.Models;

namespace CustomerManagementSystemTest.Repository
{
    public static class TestCustomers
    {
        public static List<CustomerDetailsDto> data => 
            new List<CustomerDetailsDto>
            {
                new CustomerDetailsDto
                {
                    FirstName = "Deepti",
                    LastName = "Nair",
                    DateOfBirth = new DateTime(1985, 12, 12),
                    isMale = false
                },
                new CustomerDetailsDto
                {
                    FirstName = "Rajesh",
                    LastName = "Nair",
                    DateOfBirth = new DateTime(1981, 12, 12),
                    isMale = true
                },
                new CustomerDetailsDto
                {
                    FirstName = "rema",
                    LastName = "Nair",
                    DateOfBirth = new DateTime(1985, 12, 12),
                    isMale = false
                },
            };
    }
}
