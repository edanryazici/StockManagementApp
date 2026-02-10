using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace StockManagementApp.Products
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
        Task<Product?> FindByCodeAsync(string code, CancellationToken cancellationToken = default);

        Task<List<Product>> GetListAsync(
            string? filter = null,
            string? sortting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            CancellationToken cancellationToken = default);

        Task<long> GetCountAsync(string? filtter = null, CancellationToken cancellationToken = default);
    }
}
