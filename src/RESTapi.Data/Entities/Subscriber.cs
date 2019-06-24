using RESTapi.Data.Entities.Base;
using RESTapi.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESTapi.Data.Entities
{
    public class Subscriber : EntityBase<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int? AreaId { get; set; }
        public Area Area { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
    }
}
