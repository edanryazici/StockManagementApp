using AutoMapper;

using StockManagementApp.Customers;

namespace StockManagementApp
{
    
    public class StockManagementAppApplicationAutoMapperProfile : Profile
    {
        public StockManagementAppApplicationAutoMapperProfile()
        {
            CreateMap<Customer, CustomerDto>();
        }
    }
}