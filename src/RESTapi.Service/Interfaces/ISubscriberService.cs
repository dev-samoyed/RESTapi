using System;
using System.Collections.Generic;
using System.Text;
using RESTapi.Data.Entities;
using RESTapi.Service.Models;
using RESTapi.Data.Enums;
using System.Threading.Tasks;

namespace RESTapi.Service.Interfaces
{
    public interface ISubscriberService : IBaseQueryService<Subscriber, SubscriberModel, SortType>
    {
        Task<int> AddSubscriberAsync(SubscriberModel subscriber);
        Task<SubscriberShowModel> GetSubscriberByIdAsync(int id);
        Task<int> EditSubscriberAsync(SubscriberModel subscriber);
    }
}
