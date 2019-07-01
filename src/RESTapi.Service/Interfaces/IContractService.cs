using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RESTapi.Data.Entities;
using RESTapi.Data.Enums;
using RESTapi.Service.Models;

namespace RESTapi.Service.Interfaces
{
    public interface IContractService : IBaseQueryService<Contract, ContractModel, SortType>
    {
        Task<string> GetBatchAsync(DateTime dateTime);
    }
}
