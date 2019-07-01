using RESTapi.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESTapi.Data.Entities
{
    public class Currency : EntityBase<int>
    {
        public string Name { get; set; }
    }
}
