using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class AreaService : BaseQueryService<Area, AreaModel, SortType>, IAreaService
    {
        public AreaService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public async Task<int> AddAreaAsync(AreaModel areaModel)
        {
            var area = _mapper.Map<Area>(areaModel);
            await _uow.GetRepository<Area>().InsertAsync(area);
            await _uow.SaveChangesAsync();
            return area.Id;
        }

        protected override IQueryable<Area> Order(IQueryable<Area> items, bool isFirst, QueryOrder<SortType> order)
        {
            return items;
        }

        protected override IQueryable<Area> Search(IQueryable<Area> items, QuerySearch search)
        {
            return items;
        }
    }
}
