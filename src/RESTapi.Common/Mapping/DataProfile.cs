using AutoMapper;
using RESTapi.Data.Entities;
using RESTapi.Service.Models;

namespace RESTapi.Common.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<Contract, ContractModel>(MemberList.None).ReverseMap();
        }
    }
}
