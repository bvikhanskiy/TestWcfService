using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
    public interface IInventory
    {
        Int64 Id { get; set; }
        String Name { get; set; }
        double? Price { get; set; }
    }
}
