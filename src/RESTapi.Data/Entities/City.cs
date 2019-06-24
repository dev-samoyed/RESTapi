using System;
using System.Collections.Generic;
using System.Text;
using RESTapi.Data.Entities.Base;

namespace RESTapi.Data.Entities
{
    public class City : EntityBase<int>
    {
        public string Name { get; set; }
    }
}
