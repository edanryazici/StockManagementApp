using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace StockManagementApp.Customers
{
    public interface ICustomerAppService : IApplicationService
    {
        Task<List<CustomerDto>> GetListAsync(); 
        Task<CustomerDto> GetAsync(Guid id);
        Task<CustomerDto> GetByCodeAsync(string code);
        Task<CustomerDto> CreateAsync(CustomerCreateDto input);
    }
}
