using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RESTapi.Data.Entities;
using RESTapi.Data.Enums;
using RESTapi.Service.Models;

namespace RESTapi.Service.Interfaces
{
    public interface ICityService : IBaseQueryService<City, CityModel, SortType>
    {
        Task<int> AddCityAsync(CityModel city);
    }
}
