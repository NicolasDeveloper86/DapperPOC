using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Filters
{
    public class PersonFilter : BaseFilter
    {
        public PersonFilter()
        {
            Page = 0;
            Size = 0;
            ByFirstName = string.Empty;
        }

        public string ByFirstName { get; set; }
    }
}
