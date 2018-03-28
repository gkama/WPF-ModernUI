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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkWPF
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            string query = constructQuery();
            queryResult.Content = query;
        }

        private string constructQuery()
        {
            return
                "select " +
                (selectTopListBox.SelectedItem as ListBoxItem).Content.ToString() +
                " from " +
                (dbListBox.SelectedItem as ListBoxItem).Content.ToString();
        }
    }
}
