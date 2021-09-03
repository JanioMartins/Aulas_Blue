using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.API
{
    public class APIResponse<T>
    {

        public bool Succeed { get; set; }
        public string Message { get; set; }

        public T Results { get; set; }
    }
}
