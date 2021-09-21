using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kysu.API.Response
{
    public class ResponseAPI<T>
    {
        public Status Status { get; set; }
        public T Data { get; set; }
    }
}
