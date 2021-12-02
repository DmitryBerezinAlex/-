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
    /// Логика взаимодействия для TeacherRedact.xaml
    /// </summary>
    public partial class TeacherRedact : Window
    {
        TeacherMethod TeacherMethod = new TeacherMethod();
        Database Database = new Database();
        public TeacherRedact()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClassBox.ItemsSource = Database.Class.ToList();
            Teachers Teacher = new Teachers();
          
            var RedactGridFulling = from Teachers in Database.Teachers join Class in Database.Class on Teachers.ClassID equals Class.ClassID
                                    select new
                                    {
                                        Teachers.TeacherID,
                                        Teachers.LastName,
                                        Teachers.FirstName,
                                        Teachers.SecondName,
                                        Teachers.Subject,
                                        Teachers.Classroom,
                                        Teachers.DateTime,
                                        Class.Name
                                     };
            RedactGrid.ItemsSource = RedactGridFulling.ToList();
        }

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            Teachers teacher= RedactGrid.SelectedItem as Teachers;
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
            if (TeacherMethod.RedactTeacher(teacher != null ? teacher.TeacherID:Convert.ToInt32(IDBox.Text), LastNameBox.Text, FirstNameBox.Text, MiddleNameBox.Text, Clas.ClassID,Convert.ToInt32(Classroom.Text), SubjectBox.Text,Convert.ToDateTime(DateTimeBox.Text)) == true)

            {
                LastNameBox.Clear();
                FirstNameBox.Clear();
                MiddleNameBox.Clear();
                ClassBox.SelectedIndex = -1;
                var RedactGridFulling = from Teachers in Database.Teachers
                                        join Class in Database.Class on Teachers.ClassID equals Class.ClassID
                                        select new
                                        {
                                            Teachers.TeacherID,
                                            Teachers.LastName,
                                            Teachers.FirstName,
                                            Teachers.SecondName,
                                            Teachers.Subject,
                                            Teachers.Classroom,
                                            Teachers.DateTime,
                                            Class.Name
                                        };
                RedactGrid.ItemsSource = RedactGridFulling.ToList();
            }
            
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("При изменении параметров преподавателя, сначала введите ID нужного преподавателя в поле 'ID'\n" +
                "После чего выберите нужную запись из списка введите остальные параметры после нажмите кнопку 'Изменить' Все обязательные значения помечены знаком '*'\n Напоминаем! В поле кабинет вводить" +
                "только его числовое значение!");
        }

        private void FormatQuestion_Click(object sender, RoutedEventArgs e)
        { 
            MessageBox.Show("Поле 'Дата и время' вводится в формате ГГГГ-ММ-ДД ЧЧ:ММ:СС в случае неправильного ввода будет выдана ошибка");
        }
    }
}
