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

namespace AttributeValueChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pgrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        {
            if (e.DisplayName == "MaritalStatus" || e.DisplayName == "NetSalary")
                e.Cancel = true;
            else if (e.DisplayName == "Email")
            {
                e.Description = "Email address of the employee";
                e.Order = 6;
                e.DisplayName = "Email ID";
                e.Category = "Contact Details";
            }
                else if (e.DisplayName == "FirstName")
            {
                e.Description = "First Name of the employee";
                e.Order = 0;
                e.DisplayName = "First Name";
                e.Category = "Identity";
            }
                else if (e.DisplayName == "Designation")
            {
                e.Description = "Position of the employee in the organisation";
                e.DisplayName = "Designation";
                e.Category = "Identity";
            }
                else if (e.DisplayName == "LastName")
            {
                e.Description = "Last Name of the employee";
                e.Order = 1;
                e.DisplayName = "Last Name";
                e.Category = "Identity";
            }
                else if (e.DisplayName == "ID")
            {
                e.Description = "ID of the employee";
                e.DisplayName = "Employee ID";
                e.Category = "Identity";
            }
            else if (e.DisplayName == "DOB")
            {
                e.Description = "Birth date of the employee";
                e.Order = 4;
                e.DisplayName = "Date of Birth";
                e.Category = "Identity";
            }
                else if (e.DisplayName == "Mobile")
            {
                e.Description = "Contact Number of the employee";
                e.Order = 5;
                e.DisplayName = "Mobile Number";
                e.Category = "Contact Details";
            }
                else if (e.DisplayName == "Age")
            {
                e.Description = "Age of the employee";
                e.Order = 2;
                e.DisplayName = "Age";
                e.Category = "Identity";
            }
        }
    }
}
