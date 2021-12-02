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

namespace TechnicalRequest
{
    /// <summary>
    /// Логика взаимодействия для StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        StudentMethod StudentMethod = new StudentMethod();
        Database Database = new Database();
        public StudentsWindow()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("При добавлении студента введите все данные " +
                "в поля под кнопками, и нажмите кнопку 'Добавить'.\n При удалении студента введите его имя, фамилию, и класс \n" +
                "Все обязательные поля помечены знаком * ");
        }

        private void StudWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Students stud = new Students();
            var GridFulling = from Students in Database.Students
                              join Class in Database.Class on Students.ClassID equals Class.ClassID
                              select new { Students.LastName, Students.FirstName, Students.SecondName, Class.Name };
            StudentGrid.ItemsSource = GridFulling.ToList();
            ClassBox.ItemsSource = Database.Class.ToList();
        }

        private void StudWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow MainMenu = new MainWindow();
            MainMenu.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var Clas = Database.Class.Where(item1 => item1.Name == ClassBox.Text).FirstOrDefault();
            if (StudentMethod.AddStudent(LastNameBox.Text, FirstNameBox.Text, MiddleNameBox.Text, Clas.ClassID) == true)
            {
               LastNameBox.Clear();
                FirstNameBox.Clear();
                MiddleNameBox.Clear();
                ClassBox.SelectedIndex = -1;
            }
                var GridFulling = from Students in Database.Students
                                  join Class in Database.Class on Students.ClassID equals Class.ClassID
                                  select new { Students.LastName, Students.FirstName, Students.SecondName, Class.Name };
                StudentGrid.ItemsSource = GridFulling.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Students student = StudentGrid.SelectedItem as Students;
                if (StudentGrid.SelectedItem == null)
                {
                    MessageBox.Show("Вы не выбрали строку.");
                    return;
                }
                var StudentID = Database.Students.Where(item => item.FirstName == student.FirstName && item.LastName == student.LastName).FirstOrDefault();
                StudentMethod.DeleteStudent(student.StudentID);
                var GridFulling = from Students in Database.Students
                                  join Class in Database.Class on Students.ClassID equals Class.ClassID
                                  select new { Students.LastName, Students.FirstName, Students.SecondName, Class.Name };
                StudentGrid.ItemsSource = GridFulling.ToList();

            }
            catch (Exception Error)
            { MessageBox.Show("Введите имя и фамилию ученика на удаление."); }
            Database.SaveChanges();
            StudentGrid.ItemsSource = Database.Students.ToList();
        }

        private void RedactButton_Click(object sender, RoutedEventArgs e)
        {
            StudentRedact redact = new StudentRedact();
            redact.Show();
        }
    }
}
