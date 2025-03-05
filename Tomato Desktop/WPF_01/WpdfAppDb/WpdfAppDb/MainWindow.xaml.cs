using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpdfAppDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductDbContext _db = new ProductDbContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData() 
        {
            ProductGrid.ItemsSource = _db.Products.ToList();
        }

        private void Add_Product(object sender, RoutedEventArgs e)
        {
            
                Product product = new Product();
                ProductWindow pWindow = new ProductWindow(product);

                if (pWindow.ShowDialog() == true)
                {
                    _db.Products.Add(product);
                    _db.SaveChanges();
                    LoadData();
                }
            
        }

        private void Delete_Product(object sender, RoutedEventArgs e)
        {
            if (ProductGrid.SelectedItem is Product p) 
            {
                _db.Products.Remove(p);
                _db.SaveChanges();
                LoadData();
            }
         
        }

        private void Update_Product(object sender, RoutedEventArgs e)
        {
            if (ProductGrid.SelectedItem is Product p)
            {
                Product product = new Product();
                product.Id = p.Id;
                product.Name = p.Name;
                product.Price = p.Price;
                product.Quantity = p.Quantity;

                ProductWindow pWindow = new ProductWindow(product);
                if (pWindow.ShowDialog() == true)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.Quantity = product.Quantity;
                    _db.Products.Update(p);
                    _db.SaveChanges();
                    LoadData();
                }

            }
        }
    }
}