using RESTapi.Data.Entities.Base;
using RESTapi.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESTapi.Data.Entities
{
    public class Contract : EntityBase<int>
    {
        public int DataId { get; set; }
        public Data Data { get; set; }
        public IList<SubjectRole> SubjectRoles { get; set; }
    }
}
