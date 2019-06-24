using System.Collections.Generic;

namespace RESTapi.Service.Query
{
    public class QueryResponse<T>
    {
        public IList<T> Data { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
    }
}
