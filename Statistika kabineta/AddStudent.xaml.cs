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

namespace Statistika_Kabineta
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        private ObservableCollection<Student> students;
        public AddStudent()
        {
            InitializeComponent();
            students = new ObservableCollection<Student>();
            StudentList.ItemsSource = students;
        }

        //Для выделения студента и экспортации его данных(конкретного студента)
        private void StudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentList.SelectedItem is Student selectedStudent) 
            {
                FullName.Text = selectedStudent.FullName;
                Hour.Text = selectedStudent.Hour.ToString();
                Questions.Text = selectedStudent.Questions;
            }

        }
        //Кнопка события добавления студента
        private void AddStudent1 (object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(FullName.Text) && int.TryParse(Hour.Text, out int hour))
                {
                    Student student = new Student();
                    FullName.Text = student.FullName;
                    hour = student.Hour;
                    Questions.Text = student.Questions;
                    students.Add(student);
                }
                else
                {
                    MessageBox.Show("Ура победа");
                }
            }
            catch
            {
                MessageBox.Show("Не работает");
            }
        }
    }
}
