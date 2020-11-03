using CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GService
{
    public class GServiceHost : IGServiceHost
    {
        public Dictionary<Int64, Customer> GetCustomers()
        {
            Dictionary<Int64, Customer> customers = new Dictionary<long, Customer>();

            using (Model1 db = new Model1())
            {
                var query = from customer in db.Customers
                            select customer;

                foreach (Customer customerItem in query)
                {
                    System.Diagnostics.Trace.WriteLine(customerItem.Name);
                    customers.Add(customerItem.Id, customerItem);
                }
            }

            return customers;
        }

        public Dictionary<Int64, Inventory> GetInventories()
        {
            Dictionary<Int64, Inventory> inventories = new Dictionary<Int64, Inventory>();

            using (Model1 db = new Model1())
            {
                var query = from inventory in db.Inventories
                            select inventory;

                foreach (Inventory inventoryItem in query)
                {
                    System.Diagnostics.Trace.WriteLine(inventoryItem.Name);
                    inventories.Add(inventoryItem.Id, inventoryItem);
                }
            }

            return inventories;
        }

        public Dictionary<Int64, Order> GetOrders()
        {
            Dictionary<Int64, Order> orders = new Dictionary<Int64, Order>(); 

            using (Model1 db = new Model1())
            {
                var query = from order in db.Orders
                            select order;

                foreach (Order orderItem in query)
                {
                    System.Diagnostics.Trace.WriteLine(orderItem.Id);
                    orders.Add(orderItem.Id, orderItem);
                }
            }

            return orders;
        }

        public bool AddCustomer(Customer customer)
        {
            bool result = false;

            if (customer != null)
            {
                using (Model1 db = new Model1())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    result = true;
                }
            }

            return result;
        }

        public bool AddInventory(Inventory inventory)
        {
            bool result = false;

            if (inventory != null)
            {
                using (Model1 db = new Model1())
                {
                    db.Inventories.Add(inventory);
                    db.SaveChanges();
                    result = true;
                }
            }

            return result;
        }

        public bool AddOrder(Order order)
        {
            bool result = false;

            if (order != null)
            {
                using (Model1 db = new Model1())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                    result = true;
                }
            }

            return result;
        }

    }
}
