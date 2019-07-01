using System;
using System.Collections.Generic;
using System.Text;
using RESTapi.Data.Entities.Base;

namespace RESTapi.Data.Entities
{
    public class SubjectRole : EntityBase<int>
    {
        public int CustomerCode { get; set; }
        public string RoleOfCustomer { get; set; }
        public DateTime RealEndDate { get; set; }
        public int GuarantorRelationship { get; set; }
    }
}
