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
    /// Логика взаимодействия для StudentRedact.xaml
    /// </summary>
    public partial class StudentRedact : Window
    {
        StudentMethod Method = new StudentMethod();
        Database Database = new Database();
        public StudentRedact()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClassBox.ItemsSource = Database.Class.ToList();
            ClassGrid.ItemsSource = Database.Class.ToList();
            var GridFulling = from Students in Database.Students join Class in Database.Class on Students.ClassID equals Class.ClassID
                              select new {Students.StudentID, Students.LastName, Students.FirstName, Students.SecondName, Class.ClassID};
            RedactGrid.ItemsSource = GridFulling.ToList();
        }

        private void RedactButton_Click(object sender, RoutedEventArgs e)
        {
            Students student = RedactGrid.SelectedItem as Students;
            if (RedactGrid.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали строку.", "Основное окно", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (RedactGrid.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали строку.", "Основное окно", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var Clas = Database.Class.Where(item1 => item1.Name == ClassBox.Text).FirstOrDefault();
            if (Method.RedactStudent(student != null ? student.StudentID:Convert.ToInt32(IDBox.Text), LastNameBox.Text, FirstNameBox.Text, MiddleNameBox.Text,Clas.ClassID) == true)

            {
                LastNameBox.Clear();
                FirstNameBox.Clear();
                MiddleNameBox.Clear();
                ClassBox.SelectedIndex = -1;
                var GridFulling = from Students in Database.Students
                                    join Class in Database.Class on Students.ClassID equals Class.ClassID
                                    select new { Students.StudentID, Students.LastName, Students.FirstName, Students.SecondName, Class.ClassID };
                RedactGrid.ItemsSource = GridFulling.ToList();
            }
        }


        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("При изменении параметров студента, сначала введите ID нужного студента в поле 'ID'\n" +
                "После чего,выберите нужную запись из списка и введите остальные параметры после нажмите кнопку 'Изменить' Все обязательные значения помечены знаком '*'");
        }
    }
}
