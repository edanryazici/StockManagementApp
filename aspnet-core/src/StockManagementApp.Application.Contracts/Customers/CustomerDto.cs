using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagementApp.Customers
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null;
        public string? Name { get; set; }
    }
}
