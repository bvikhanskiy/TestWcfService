using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace GService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //GServiceHost host = new GServiceHost();
            //host.AddOrder(new CommonTypes.Order(2, 1, 2, "123", DateTime.Now));
            //Dictionary<Int64, CommonTypes.Customer> customers = host.GetCustomers();

            //foreach(Int64 key in customers.Keys)
            //{
            //    Trace.WriteLine("-- " + customers[key].Name);
            //}

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new GService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
