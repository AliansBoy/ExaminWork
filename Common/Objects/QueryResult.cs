using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Objects
{
    public class QueryResult
    {
        public int Total { get; set; }
        public int TotalFiltered { get; set; }
        public int LastPage => Paging?.Length > 0 ? (int)Math.Ceiling((double)TotalFiltered / Paging.Length) : 0;
        public Paging Paging { get; set; }

    }
    public class QueryResult<T> : QueryResult
    {
        public List<T> Data { get; set; }

        public QueryResult() { }

        public QueryResult(int total)
        {
            Total = total;
        }
    }
}
