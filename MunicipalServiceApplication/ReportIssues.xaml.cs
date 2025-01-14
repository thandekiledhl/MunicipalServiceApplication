using Microsoft.Win32;
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
using System.IO;
using Path = System.IO.Path;
using System.Windows.Threading;


namespace MunicipalServiceApplication
{
    
    public partial class ReportIssues : Window
    {
        private DispatcherTimer progressTimer;
        public ReportIssues()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAttachMedia_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|Document Files|*.pdf;*.doc;*.docx|All Files|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFilePath = openFileDialog.FileName;

                // Displays the selected file path in the TextBlock
                txtSelectedFile.Text = Path.GetFileName(selectedFilePath);
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
                string location = locationTextBox.Text.Trim(); 
                string description = new TextRange(descriptionTB.Document.ContentStart, descriptionTB.Document.ContentEnd).Text.Trim();
                ListBoxItem selectedCategory = (ListBoxItem)categoryListBox.SelectedItem; 
                string selectedFile = txtSelectedFile.Text; 

               
                if (string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Please add a location.", "Missing Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (selectedCategory == null)
                {
                    MessageBox.Show("Please select a category.", "Missing Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(description) || description == "\r\n") 
                {
                    MessageBox.Show("Please add a description.", "Missing Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

              //when all info is added message will show
                MessageBox.Show("Report has been submitted.", "Submission Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
            }

       
        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBtn_Click(object sender, RoutedEventArgs e)
        {
            progressTimer = new DispatcherTimer();
            progressTimer.Interval = TimeSpan.FromMilliseconds(100); 
            progressTimer.Tick += ProgressTimer_Tick;
            progressTimer.Start();
        }
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {

            if (ProgressBar.Value < 100)
            {
                ProgressBar.Value += 2; 
            }
            else
            {
                progressTimer.Stop(); 
                MessageBoxResult result = MessageBox.Show("Progress completed!", "Progress", MessageBoxButton.OK, MessageBoxImage.Information);

               

            }
        }
    }
}

