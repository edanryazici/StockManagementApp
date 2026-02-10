using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace StockManagementApp.Products
{
    public class Product : AggregateRoot<Guid>
    {
        public string Code { get; set; }
        public string? Name { get; set; }

        protected Product()
        {
        }

        internal Product(Guid id,string code) : base(id)
        {
            SetCode(code);
        }

        internal void SetCode (string code)
        {
            Check.NotNullOrWhiteSpace(code, nameof(Code), ProductConsts.MaximumCodeLenght, ProductConsts.MinumumCodeLenght);
            Code = code;
        }

        internal void SetName (string? name)
        {
            Check.Length(name, nameof(Name), ProductConsts.MaximumNameLenght);
            Name = name;
        }


    }
}
