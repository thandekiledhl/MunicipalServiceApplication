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

namespace MunicipalServiceApplication
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReportIssues objReportIssues = new ReportIssues();  
            this.Visibility = Visibility.Hidden;              
            objReportIssues.Show();                          

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void annBtn_Click(object sender, RoutedEventArgs e) //Local Events and Announcements
        {
            Local objLocal = new Local();
            this.Visibility = Visibility.Hidden;
            objLocal.Show();
        }

        private void requestBtn_Click(object sender, RoutedEventArgs e) //service request
        {
            // Open the Service Request Status Form
            ServiceRequest objServiceRequest = new ServiceRequest();
            this.Visibility = Visibility.Hidden;
            objServiceRequest.Show();
        }
    }
}
