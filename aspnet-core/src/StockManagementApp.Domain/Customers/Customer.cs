using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace StockManagementApp.Customers
{
    public class Customer : AuditedAggregateRoot<Guid> //Veritabanına kayıt atmadan oluşturulan id yi öğrenmemizi sağlar
    {
        public string Code { get; protected set; }
        public string? Name { get; protected set; }

        protected Customer()
        {
            //ORM'ler için boş constructor
        }

        internal Customer(Guid id, 
            string code, 
            string name) : base(id) //Bir entity nin oluşabilmesi için olması gerekenler
        {
            
            SetCode(code);
            Name = name;
        }

        internal void SetCode(string code)
        {
            Check.NotNullOrWhiteSpace(code, nameof(Code), CustomerConsts.MaxCodeLength, CustomerConsts.MinCodeLength);
            Code = code;
        }

        public void SetName(string? name)
        {
            Check.Length(name, nameof(Name), CustomerConsts.MaxNameLength);
            Name = name;
        }
    }
}
