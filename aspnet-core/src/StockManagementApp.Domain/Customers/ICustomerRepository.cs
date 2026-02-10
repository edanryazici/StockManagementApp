using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace StockManagementApp.Customers
{
    public interface ICustomerRepository : IBasicRepository<Customer, Guid>
    {
        Task<Customer> FindByCodeAsync(string code, CancellationToken cancellationToken= default);
    }
}
