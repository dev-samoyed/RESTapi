using System;
using System.Collections.Generic;
using System.Text;
using RESTapi.Data.Entities;
using RESTapi.Service.Models;
using RESTapi.Data.Enums;
using RESTapi.Service.Interfaces;
using RESTapi.Service.Query;
using System.Linq;
using AutoMapper;
using RESTapi.Data.Interfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTapi.Service.Extensions;

namespace RESTapi.Service
{
    public class SubscriberService : BaseQueryService<Subscriber, SubscriberModel, SortType>, ISubscriberService
    {
        public SubscriberService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public async Task<int> AddSubscriberAsync(SubscriberModel subscriberModel)
        {
            var subscriber = _uow.GetRepository<Subscriber>().All()
                .FirstOrDefault(x => x.FirstName == subscriberModel.FirstName &&
                                     x.LastName == subscriberModel.LastName && 
                                     x.AreaId == subscriberModel.AreaId && 
                                     x.CityId == subscriberModel.CityId && 
                                     x.PhoneNumber == subscriberModel.PhoneNumber);
            if(subscriber != null)
            {
                throw new NotImplementedException();
            }

            subscriber = _mapper.Map<Subscriber>(subscriberModel);
            await _uow.GetRepository<Subscriber>().InsertAsync(subscriber);
            await _uow.SaveChangesAsync();
            return subscriber.Id;
        }

        public async Task<int> EditSubscriberAsync(SubscriberModel subscriberModel)
        {
            var subscriber = _uow.GetRepository<Subscriber>().All()
                .Include(x => x.City)
                .Include(x => x.Area)
                .SingleOrDefault(s => s.Id == subscriberModel.Id);

            if (subscriber == null)
            {
                throw new NotImplementedException();
            }

            subscriber = _mapper.Map<Subscriber>(subscriberModel);
            subscriber.City = _uow.GetRepository<City>().GetById(subscriber.CityId);
            subscriber.Area = _uow.GetRepository<Area>().GetById(subscriber.CityId);

            _uow.GetRepository<Subscriber>().Update(subscriber);
            _uow.SaveChanges();

            return subscriber.Id;
        }

        public async Task<SubscriberShowModel> GetSubscriberByIdAsync(int id)
        {
            var subscriber = await _uow.GetRepository<Subscriber>().All()
                .Include(x=>x.City)
                .Include(x=>x.Area)
                .SingleOrDefaultAsync(s=>s.Id == id);

            return _mapper.Map<SubscriberShowModel>(subscriber);
        }

        protected override IQueryable<Subscriber> Order(IQueryable<Subscriber> items, bool isFirst, QueryOrder<SortType> order)
        {
            switch (order.OrderType)
            {
                case SortType.FirstName:
                    return items.OrderWithDirectionBy(isFirst, order.Direction, x => x.FirstName);
                case SortType.LastName:
                    return items.OrderWithDirectionBy(isFirst, order.Direction, x => x.LastName);
            }

            throw new ArgumentOutOfRangeException(nameof(order.OrderType));
        }

        protected override IQueryable<Subscriber> Paging(IQueryable<Subscriber> items, int? start, int? length)
        {
            return items.Skip(start.Value).Take(length.Value);
        }

        protected override IQueryable<Subscriber> Search(IQueryable<Subscriber> items, QuerySearch search)
        {
            if (!string.IsNullOrEmpty(search?.Value))
            {
                return items.Where(x => x.FirstName.Contains(search.Value));
            }
            return items;
        }
        
    }
}
