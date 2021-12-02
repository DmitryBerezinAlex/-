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

namespace TechnicalRequest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Database Database = new Database();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudButton_Click(object sender, RoutedEventArgs e)
        {
            StudentsWindow students = new StudentsWindow();
            students.Show();
            this.Close();
        }

        private void TeachButton_Click(object sender, RoutedEventArgs e)
        {
            TeacherWindow Teachers = new TeacherWindow();
            Teachers.Show();
            this.Close();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {

            var StudGridFulling = from Students in Database.Students join Class in Database.Class on Students.ClassID equals Class.ClassID
                              select new { Students.LastName, Students.FirstName, Students.SecondName,Class.Name};
            StudentGrid.ItemsSource = StudGridFulling.ToList();
            var TeacherGridFullung = from Teachers in Database.Teachers
                      join Class in Database.Class on Teachers.ClassID equals Class.ClassID select new {Teachers.LastName,Teachers.FirstName,Teachers.SecondName,
                                         Teachers.Subject,Teachers.Classroom,Teachers.DateTime,Class.Name};
            TeacherGrid.ItemsSource = TeacherGridFullung.ToList();
        }
    }
}
