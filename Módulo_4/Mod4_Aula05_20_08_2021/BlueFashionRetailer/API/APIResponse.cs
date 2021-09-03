using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.API
{
    public class APIResponse<T>
    {
        public string Error { get; set; }

        public T Results { get; set; }
    }
}
