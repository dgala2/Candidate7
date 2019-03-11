using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemTest.Models;

namespace CustomerManagementSystemTest.Repository
{
    class CustomerDetailsRepository : ICustomerDetailsRepository
    {
        private List<CustomerDetailsDto> _customerDetailsDtos =
            new List<CustomerDetailsDto>();

        public CustomerDetailsRepository()
        {
            _customerDetailsDtos.AddRange(TestCustomers.data);
        }

        public void AddCustomerDetails(CustomerDetailsDto customerDetailsDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDetailsDto> GetCustomerDetails()
        {
            return _customerDetailsDtos;
        }
    }
}
