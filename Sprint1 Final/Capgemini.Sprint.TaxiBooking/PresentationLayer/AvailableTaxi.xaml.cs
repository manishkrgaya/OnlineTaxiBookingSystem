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
using BLL;
using UserException;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for AvailableTaxi.xaml
    /// </summary>
    public partial class AvailableTaxi : Window
    {
        public AvailableTaxi()
        {
            InitializeComponent();
        }

        EmployeeBLL bll = new EmployeeBLL();

        private void AvailableTaxis_Loaded(object sender, RoutedEventArgs e)
        {
            var etaxies = bll.GetTaxiDetails();
            TaxiGrid.ItemsSource = etaxies;
        }
    }
}
