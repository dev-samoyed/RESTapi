using RESTapi.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESTapi.Data.Entities
{
    public class TotalAmount: EntityBase<int>
    {
        public decimal Value { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
