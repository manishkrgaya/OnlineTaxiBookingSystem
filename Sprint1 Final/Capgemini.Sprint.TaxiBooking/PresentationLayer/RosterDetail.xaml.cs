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
    /// Interaction logic for RosterDetail.xaml
    /// </summary>
    public partial class RosterDetail : Window
    {
        public RosterDetail()
        {
            InitializeComponent();
        }

        private void SearchButton_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeeBLL bll = new EmployeeBLL();
                BLL.EmployeeValidation val = new BLL.EmployeeValidation();
                if (!val.ValidateEmployeeID(TxtEmployeeId.Text))
                {
                    throw new TaxiBookingException("EmployeeID should not be empty!!");

                }
                else
                {
                    int Id = Convert.ToInt32(TxtEmployeeId.Text.ToString());
                    var emproaster = bll.GetAllEmployeeRoasterDetails(Id);
                    RosterGrid.ItemsSource = emproaster;
                    LblMessage.Content = "";
                }
            }
            catch (TaxiBookingException ex)
            {
                LblMessage.Content = ex.Message;
            }
            catch (Exception ex)
            {
                LblMessage.Content = ex.Message;
            }
        }
    }
}
