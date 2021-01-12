using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Filters
{
    public abstract class BaseFilter
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
