using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
    public interface IOrder
    {
        Int64 Id { get; set; }
        Int64 IdInventory { get; set; }
        Int64 IdCustomer { get; set; }
        String Comment { get; set; }
        DateTime DateEvent { get; set; }
    }
}
