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
    /// Interaction logic for AddInventoryWindow.xaml
    /// </summary>
    public partial class AddInventoryWindow : Window
    {
        public String InventoryName { get; set; }
        public float Price { get; set; }

        public AddInventoryWindow()
        {
            InitializeComponent();
        }

        private bool getFormData()
        {
            bool result = false;
            float price = 0f;

            InventoryName = txtName.Text.Trim();
            if (float.TryParse(txtPrice.Text.Trim(), out price) && (!String.IsNullOrEmpty(InventoryName)))
            {
                Price = price;
                result = true;
            }

            return result;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (getFormData())
            {
                DialogResult = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
