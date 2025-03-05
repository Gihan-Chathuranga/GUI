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

namespace WpdfAppDb
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public Product Product { get; private set; }
        public ProductWindow(Product product)
        {
            InitializeComponent();
            Product = product;
            NameTexbox.Text = product.Name;
            QuantityTexbox.Text = product.Quantity.ToString();
            PriceTexbox.Text = product.Price.ToString();
        }

        private void Save_Product(object sender, RoutedEventArgs e)
        {
            try
            {
                Product.Name = NameTexbox.Text;
                Product.Price = Convert.ToDecimal(PriceTexbox.Text);
                Product.Quantity = Convert.ToInt32(QuantityTexbox.Text);
                DialogResult = true;
                Close();
            }
            catch 
            {
                MessageBox.Show("Please enter valid data");
                DialogResult = false;
                Close();
            }

        }
    }
}
