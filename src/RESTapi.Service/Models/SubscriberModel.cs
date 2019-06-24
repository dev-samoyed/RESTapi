using RESTapi.Service.Models.Base;
using RESTapi.Data.Enums;
using System;

namespace RESTapi.Service.Models
{
    public class SubscriberModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int? AreaId { get; set; }
        public int? CityId { get; set; }
    }
}
