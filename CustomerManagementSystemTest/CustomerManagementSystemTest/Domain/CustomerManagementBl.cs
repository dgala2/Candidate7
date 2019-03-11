using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemTest.Models;
using CustomerManagementSystemTest.Repository;

namespace CustomerManagementSystemTest.Domain
{
    public class CustomerManagementBl
    {
        private ICustomerDetailsRepository _customerDetailsRepository;
        public CustomerManagementBl(ICustomerDetailsRepository customerDetailsRepository)
        {
            _customerDetailsRepository = customerDetailsRepository;
        }
        public void DisplayStatistics()
        {
            var customerDetails = _customerDetailsRepository.GetCustomerDetails();

            DisplayAverageAgeForBothMaleAndFemales(customerDetails);
            DisplayAverageAgeOfEveryone(customerDetails);
        }

        private void DisplayAverageAgeForBothMaleAndFemales(IEnumerable<CustomerDetailsDto> customerDetailsDtos)
        {
            var stats = customerDetailsDtos
                .GroupBy(customerDetailsDto => customerDetailsDto.isMale, 
                    c => c.Age)
                .Select(g => new
                {
                    isMale = g.Key,
                    averageAge = g.Average()
                });

            Console.WriteLine("Average Age males: {0}", stats.Where(x => x.isMale).Select(x => x.averageAge).FirstOrDefault().ToString());
            Console.WriteLine("Average Age females: {0}", stats.Where(x => !x.isMale).Select(x => x.averageAge).FirstOrDefault().ToString());
        }

        private void DisplayAverageAgeOfEveryone(IEnumerable<CustomerDetailsDto> customerDetailsDtos)
        {
            var stats = customerDetailsDtos
                .Select(customerDetailsDto => customerDetailsDto.Age)
                .Average();

            Console.WriteLine("Average age all: {0}",stats);
        }
    }
}

