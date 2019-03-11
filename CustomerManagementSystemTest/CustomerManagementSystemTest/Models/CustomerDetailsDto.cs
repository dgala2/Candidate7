using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystemTest.Models
{
    public class CustomerDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; }

        public int Age =>  DateTime.Now.Year - DateOfBirth.Year;
        public bool isMale { get; set; }
    }
}
