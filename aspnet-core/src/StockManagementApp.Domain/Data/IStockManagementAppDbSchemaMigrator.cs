using System.Threading.Tasks;

namespace StockManagementApp.Data;

public interface IStockManagementAppDbSchemaMigrator
{
    Task MigrateAsync();
}
