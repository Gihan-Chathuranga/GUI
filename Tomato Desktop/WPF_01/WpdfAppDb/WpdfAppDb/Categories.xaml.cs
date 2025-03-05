using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class Categories : Window
    {

        public ObservableCollection<string> categories { get; set; } = new ObservableCollection<string>();
        public Categories()
        {
            InitializeComponent();
            lstCategories.ItemsSource = categories;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string newCategory = txtCategory.Text.Trim();

            if (!string.IsNullOrEmpty(newCategory) && !categories.Contains(newCategory))
            {
                categories.Add(newCategory); // Add new category
                txtCategory.Clear();
            }
            else
            {
                MessageBox.Show("Enter a valid and unique category!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Delete Category Button Click Event
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstCategories.SelectedItem != null) // Check if an item is selected
            {
                // Cast SelectedItem to string

                if (lstCategories.SelectedItem is string selectedCategory) // Ensure it is not null
                {
                    categories.Remove(selectedCategory); // Remove from ObservableCollection
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void TxtCategory_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtCategory.Text == "Enter Category")
            {
                txtCategory.Text = "";
                txtCategory.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TxtCategory_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                txtCategory.Text = "Enter Category";
                txtCategory.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

    }
}
