using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
    public interface IOrders : IEnumerable
    {
        IOrder this[int i] { get; set; }
        void Add(IOrder order);
        void Delete(Int64 id);
    }
}
