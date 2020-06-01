using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Objects
{
    public class Paging
    {
        public int Skip => (Page - 1) * Length;
        public int Length { get; set; }
        public int Page { get; set; }

        public Paging()
        {
            Length = 10;
            Page = 1;
        }
    }
}
