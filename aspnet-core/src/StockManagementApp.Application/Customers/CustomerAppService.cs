using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectMapping;

namespace StockManagementApp.Customers
{
    public class CustomerAppService : StockManagementAppAppService, ICustomerAppService
    {
        public CustomerAppService(ICustomerRepository customerRepository, CustomerManager customerManager) 
        {
            CustomerRepository = customerRepository;
            CustomerManager = customerManager;
        }

        public ICustomerRepository CustomerRepository { get; }
        public CustomerManager CustomerManager { get; }

        public async Task<CustomerDto> CreateAsync(CustomerCreateDto input)
        {
            var customer = await CustomerManager.CreateAsync(input.Code);
            customer.SetName(input.Name);
            await CustomerRepository.InsertAsync(customer);
            return ObjectMapper.Map<Customer, CustomerDto>(customer);

        }

        public async Task<CustomerDto> GetAsync(Guid id)
        { 
             return ObjectMapper.Map<Customer, CustomerDto>(await CustomerRepository.GetAsync(id));
        }

        public async Task<CustomerDto> GetByCodeAsync(string code)
        {
            var customer = await CustomerRepository.FindByCodeAsync(code);

            if(customer == null)
            {
                throw new UserFriendlyException(message: $"{code} bu kodlu müşteri bulunamadı");
            }

            return ObjectMapper.Map<Customer, CustomerDto>(customer);
        }

        public async Task<List<CustomerDto>> GetListAsync()
        {
            var customers = await CustomerRepository.GetListAsync();
            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);
        }
    }
}
