using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Objects
{
    public class BaseQuery
    {
        public ColumnOrder OrderBy { get; set; }
        public Paging Paging { get; set; }

        public BaseQuery()
        {
            Paging = new Paging();
        }
    }
}
