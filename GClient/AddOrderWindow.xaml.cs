using CommonTypes;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace GClient
{
    /// <summary>
    /// Interaction logic for AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        public Customer Customer { get; set; }
        public Inventory Inventory { get; set; }
        public DateTime EventDate { get; set; }
        public String Comment { get; set; }

        public AddOrderWindow()
        {
            InitializeComponent();
        }

        public AddOrderWindow(Dictionary<Int64, Customer> customers, Dictionary<Int64, Inventory> inventories)
        {
            InitializeComponent();

            cbCustomer.ItemsSource = customers.Values;
            cbCustomer.DisplayMemberPath = "Name";
            cbInventory.ItemsSource = inventories.Values;
            cbInventory.DisplayMemberPath = "Name";

            btnAdd.IsEnabled = false;
        }

        private void checkOrder()
        {
            Customer = cbCustomer.SelectedItem as Customer;
            Inventory = cbInventory.SelectedItem as Inventory;
            EventDate = (dtpEventDate.SelectedDate.HasValue) ? dtpEventDate.SelectedDate.Value : DateTime.MinValue;

            if ((Customer != null) &&
                (Inventory != null) &&
                (EventDate != DateTime.MinValue)
               )
            {
                btnAdd.IsEnabled = true;
            }
            else
            {
                btnAdd.IsEnabled = false;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void CbCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkOrder();
        }

        private void CbInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkOrder();
        }

        private void DtpEventDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            checkOrder();
        }

        private void TxtComment_TextChanged(object sender, TextChangedEventArgs e)
        {
            Comment = txtComment.Text;
        }
    }
}
