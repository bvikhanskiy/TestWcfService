using CommonTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<Int64, Customer> customers;
        Dictionary<Int64, Inventory> inventories;
        Dictionary<Int64, Order> orders;

        public MainWindow()
        {
            customers = null;
            inventories = null;
            orders = null;
            InitializeComponent();

            btnAddCustomer.IsEnabled = false;
            btnAddInventory.IsEnabled = false;
            btnAddOrder.IsEnabled = false;
        }

        private Task retrieveDataAsync()
        {
            return Task.Run(() => retrieveData());
        }

        async private void retrieveData()
        {
            GServiceReference.GServiceHostClient proxy = new GServiceReference.GServiceHostClient();

            customers = await proxy.GetCustomersAsync();
            inventories = await proxy.GetInventoriesAsync();
            orders = await proxy.GetOrdersAsync();

            var ordersView = from order in orders
                             from customer in customers
                             from inventory in inventories
                             where (order.Value.IdCustomer == customer.Value.Id) &&
                                   (order.Value.IdInventory == inventory.Value.Id)
                             select new
                             {
                                 Id = order.Value.Id,
                                 CustomerName = customer.Value.Name,
                                 InventoryName = inventory.Value.Name,
                                 DateEvent = order.Value.DateEvent
                             };

            dgOrders.Dispatcher.Invoke(() => dgOrders.ItemsSource = ordersView);

            btnAddCustomer.Dispatcher.Invoke(() => btnAddCustomer.IsEnabled = true);
            btnAddInventory.Dispatcher.Invoke(() => btnAddInventory.IsEnabled = true);
            btnAddOrder.Dispatcher.Invoke(() => btnAddOrder.IsEnabled = true);
        }

        async private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await retrieveDataAsync();
        }

        async private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow(customers, inventories);
            bool? dlgRes = addOrderWindow.ShowDialog();
            if (dlgRes.HasValue && dlgRes.Value)
            {
                Int64 maxOrderId = orders.Values.Select(order => order.Id).Max();
                Order newOrder = new Order(maxOrderId + 1, addOrderWindow.Inventory.Id, addOrderWindow.Customer.Id, addOrderWindow.Comment, addOrderWindow.EventDate);
                GServiceReference.GServiceHostClient proxy = new GServiceReference.GServiceHostClient();
                await proxy.AddOrderAsync(newOrder);
                await retrieveDataAsync();
            }
        }

        async private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerWindow addCustomerWindow = new AddCustomerWindow();
            bool? dlgRes = addCustomerWindow.ShowDialog();
            if (dlgRes.HasValue && dlgRes.Value)
            {
                Int64 maxCustomerId = customers.Values.Select(customer => customer.Id).Max();
                Customer newCustomer = new Customer(maxCustomerId + 1, addCustomerWindow.CustomerName, addCustomerWindow.Vip);
                GServiceReference.GServiceHostClient proxy = new GServiceReference.GServiceHostClient();
                await proxy.AddCustomerAsync(newCustomer);
                await retrieveDataAsync();
            }
        }

        async private void BtnAddInventory_Click(object sender, RoutedEventArgs e)
        {
            AddInventoryWindow addInventoryWindow = new AddInventoryWindow();
            bool? dlgRes = addInventoryWindow.ShowDialog();
            if (dlgRes.HasValue && dlgRes.Value)
            {
                Int64 maxInventoryId = inventories.Values.Select(inventory => inventory.Id).Max();
                Inventory newInventory = new Inventory(maxInventoryId + 1, addInventoryWindow.InventoryName, addInventoryWindow.Price);
                GServiceReference.GServiceHostClient proxy = new GServiceReference.GServiceHostClient();
                await proxy.AddInventoryAsync(newInventory);
                await retrieveDataAsync();
            }
        }
    }
}
