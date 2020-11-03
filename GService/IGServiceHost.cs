using CommonTypes;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GService
{
    [ServiceContract]
    interface IGServiceHost
    {
        [OperationContract]
        [FaultContract(typeof(Exception))]
        Dictionary<Int64, Customer> GetCustomers();

        [OperationContract]
        [FaultContract(typeof(Exception))]
        Dictionary<Int64, Inventory> GetInventories();

        [OperationContract]
        [FaultContract(typeof(Exception))]
        Dictionary<Int64, Order> GetOrders();

        [OperationContract]
        [FaultContract(typeof(Exception))]
        bool AddCustomer(Customer customer);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        bool AddInventory(Inventory inventory);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        bool AddOrder(Order order);

    }
}
