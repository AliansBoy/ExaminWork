using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;

namespace Common.Objects
{
    public class ColumnOrder
    {
        [DisplayName("Sort")]
        public string Column { get; set; }
        [DisplayName("Descending")]
        public SortDirection Direction { get; set; }

        public override string ToString()
        {
            return $"{Column} {Direction.ToString().ToUpperInvariant()}";
        }

        public ColumnOrder() { }

        public ColumnOrder(string column, SortDirection direction = SortDirection.Asc)
        {
            Column = column;
            Direction = direction;
        }
    }
}
