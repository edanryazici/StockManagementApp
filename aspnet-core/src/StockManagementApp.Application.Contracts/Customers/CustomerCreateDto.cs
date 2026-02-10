using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using Volo.Abp.Validation;

namespace StockManagementApp.Customers;

public class CustomerCreateDto
{
    [Required]
    [DynamicStringLength(typeof(CustomerConsts), nameof(CustomerConsts.MaxCodeLength), nameof(CustomerConsts.MinCodeLength))]
    public string Code { get; set; } = null;
    public string? Name { get; set; }

}
