using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RESTapi.Data.Entities;
using RESTapi.Data.Enums;
using RESTapi.Data.Interfaces;
using RESTapi.Service.Interfaces;
using RESTapi.Service.Models;
using RESTapi.Service.Query;

namespace RESTapi.Service
{
    public class ContractService : BaseQueryService<Contract, ContractModel, SortType>, IContractService
    {
        public ContractService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public async Task<string> GetBatchAsync(DateTime dateTime)
        {
            var batch = await _uow.GetRepository<Contract>().All()
                .Include(x => x.Data)
                    .ThenInclude(x => x.Currency)
                .Include(x => x.Data)
                    .ThenInclude(x => x.TotalMontlyPayment)
                .Include(x => x.Data)
                    .ThenInclude(x => x.TotalAmount)
                .Include(x => x.Data)
                    .ThenInclude(x => x.ProlongationAmount)
                .Include(x => x.SubjectRoles)
                .Where(b=>b.Data.StartDate == dateTime).FirstOrDefaultAsync();
          
            var xmlBatch = new XElement("Batch", batch);
            return xmlBatch.ToString();
        }

        protected override IQueryable<Contract> Order(IQueryable<Contract> items, bool isFirst, QueryOrder<SortType> order)
        {
            return items;
        }

        protected override IQueryable<Contract> Search(IQueryable<Contract> items, QuerySearch search)
        {
            return items;
        }
    }
}
