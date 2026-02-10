using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace StockManagementApp.Customers
{
    public class CustomerManager : DomainService
    {
        public ICustomerRepository CustomerRepository { get; }
        public CustomerManager(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        public async Task<Customer> CustomerAsync(string code)
        {
            var existingCustomer = await CustomerRepository.FindByCodeAsync(code);
            if(existingCustomer != null)
            {
                throw new BusinessException(StockManagementAppDomainErrorCodes.CustomerCodeAlreadyExists).WithData(name:"CustomeCode", code); //Localization kısmını entegre etmiş oluyoruz. Bu sayede hata mesajlarında müşteri kodunu da gösterebiliriz.
            }
            return new Customer(GuidGenerator.Create(), code, name:code);
        }

        public async Task<Customer> CreateAsync(string code)
        {
            var existingCustomer = await CustomerRepository.FindByCodeAsync(code);
            if (existingCustomer != null)
            {
                throw new BusinessException(StockManagementAppDomainErrorCodes.CustomerCodeAlreadyExists)
                    .WithData(name: "CustomerCode", code);
            }

            return new Customer(GuidGenerator.Create(), code, name:code);
        }


    }
}
