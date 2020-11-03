using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
    public interface ICustomer
    {
        Int64 Id { get; set; }
        String Name { get; set; }
        bool? Vip { get; set; }
    }
}
