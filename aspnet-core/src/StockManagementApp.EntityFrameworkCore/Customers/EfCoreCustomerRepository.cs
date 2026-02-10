using Microsoft.EntityFrameworkCore;
using StockManagementApp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace StockManagementApp.Customers
{
    public class EfCoreCustomerRepository : EfCoreRepository<StockManagementAppDbContext, Customer, Guid>, ICustomerRepository
    {
        public EfCoreCustomerRepository(IDbContextProvider<StockManagementAppDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        public async Task<Customer?> FindByCodeAsync(string code, CancellationToken cancellationToken=default)
        {
            IQueryable<Customer?> dbSet = await GetQueryableAsync();
            return await dbSet.FirstOrDefaultAsync(x => x.Code == code, cancellationToken);
        }

        public Task<Customer> FindByCodeAsync(string code)
        {
            throw new NotImplementedException();
        }
    }
}
