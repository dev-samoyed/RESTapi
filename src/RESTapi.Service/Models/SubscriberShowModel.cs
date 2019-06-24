using System;
using System.Collections.Generic;
using System.Text;
using RESTapi.Service.Models.Base;

namespace RESTapi.Service.Models
{
    public class SubscriberShowModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string AreaName { get; set; }
        public string CityName { get; set; }
    }
}
