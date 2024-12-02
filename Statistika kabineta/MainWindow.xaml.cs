using System;
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

namespace Statistika_Kabineta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students;

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
            PeopleList.ItemsSource = students;
        }

        private void InitializeData()
        {
            students = new List<Student>
            {
           
          
            };
        }

        private void PeopleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PeopleList.SelectedItem is Student selectedPerson)
            {
                FullNameText.Text = selectedPerson.FullName;
                HoursText.Text = selectedPerson.Hour.ToString();
                QuestionText.Text = selectedPerson.Questions;
            }
        }

        private void ExportToPDF_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void GoToNahui (object sender, RoutedEventArgs e)
        {
           
        }
    }
}