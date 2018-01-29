using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huobi.Rest.CSharp.Demo.Model
{
    public class HBResponse<T> where T : class
    {
        public string Status { get; set; }
        public T Data { get; set; }
    }
}
