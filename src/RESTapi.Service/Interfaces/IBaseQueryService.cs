using RESTapi.Data.Interfaces;
using RESTapi.Service.Query;
using System.Threading.Tasks;

namespace RESTapi.Service.Interfaces
{
    public interface IBaseQueryService<TEntity, TModel, TSortType>
        where TEntity : class, IEntityBase, new()
    {
        Task<QueryResponse<TModel>> GetAsync(QueryRequest<TSortType> query);
    }
}
