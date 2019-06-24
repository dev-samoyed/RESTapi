using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using RESTapi.Data.Entities;
using RESTapi.Data.Enums;
using RESTapi.Data.Interfaces;
using RESTapi.Service.Interfaces;
using RESTapi.Service.Models;
using RESTapi.Service.Query;

namespace RESTapi.Service
{
    public class CityService : BaseQueryService<City, CityModel, SortType>, ICityService
    {
        public CityService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public async Task<int> AddCityAsync(CityModel cityModel)
        {
            var city = _uow.GetRepository<City>().All()
                .FirstOrDefault(x => x.Name == cityModel.Name);

            if (city != null)
            {
                throw new NotImplementedException();
            }

            city = _mapper.Map<City>(cityModel);
            await _uow.GetRepository<City>().InsertAsync(city);
            await _uow.SaveChangesAsync();
            return city.Id;
        }

        protected override IQueryable<City> Order(IQueryable<City> items, bool isFirst, QueryOrder<SortType> order)
        {
            return items;
        }

        protected override IQueryable<City> Search(IQueryable<City> items, QuerySearch search)
        {
            return items;
        }
    }
}
