using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemTest.Models;

namespace CustomerManagementSystemTest.Repository
{
    public interface ICustomerDetailsRepository
    {
        void AddCustomerDetails(CustomerDetailsDto customerDetailsDto);
        IEnumerable<CustomerDetailsDto> GetCustomerDetails();
    }
}
