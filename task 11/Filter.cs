using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    internal class Filter
    {
        public string FilterType { get; set; }
        public string Parameter { get; set; }

        public Filter(string filterType, string parameter)
        {
            FilterType = filterType;
            Parameter = parameter;
        }
    }
}
