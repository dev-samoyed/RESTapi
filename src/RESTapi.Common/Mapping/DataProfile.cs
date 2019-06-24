using AutoMapper;
using RESTapi.Data.Entities;
using RESTapi.Service.Models;

namespace RESTapi.Common.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<Subscriber, SubscriberModel>(MemberList.None).ReverseMap();
            CreateMap<City, CityModel>(MemberList.None).ReverseMap();
            CreateMap<Area, Area>(MemberList.None).ReverseMap();
            CreateMap<Subscriber, SubscriberShowModel>(MemberList.None).ReverseMap();
        }
    }
}
