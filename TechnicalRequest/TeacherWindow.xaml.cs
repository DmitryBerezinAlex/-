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
    /// Логика взаимодействия для TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        Database Database = new Database();
        TeacherMethod TeacherMethod = new TeacherMethod();
        public TeacherWindow()
        {
            InitializeComponent();
        }

        private void TeacherWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            ClassBox.ItemsSource = Database.Class.ToList();
            var TeacherGridFulling = from Teachers in Database.Teachers join Class in Database.Class on Teachers.ClassID equals Class.ClassID
                                     select new
                                     {
                                         Teachers.LastName,
                                         Teachers.FirstName,
                                         Teachers.SecondName,
                                         Teachers.Subject,
                                         Teachers.Classroom,
                                         Teachers.DateTime,
                                         Class.Name
                                     };
            TeacherGrid.ItemsSource = TeacherGridFulling.ToList();
        }


        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("При добавлении преподавателя введите все данные " +
               "в поля , и нажмите кнопку 'Добавить'.\n При удалении преподавателя введите его имя, фамилию,класс и предмет \n" +
               "Все обязательные поля помечены знаком * ");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               Teachers Teacher = TeacherGrid.SelectedItem as Teachers;
                if (TeacherGrid.SelectedItem == null)
                {
                    MessageBox.Show("Вы не выбрали строку.");
                    return;
                }
                var TeacherID = Database.Teachers.Where(item => item.FirstName == Teacher.FirstName && item.LastName == Teacher.LastName).FirstOrDefault();
                TeacherMethod.DeleteTeacher(Teacher.TeacherID);
                var TeacherGridFulling = from Teachers in Database.Teachers
                                         join Class in Database.Class on Teachers.ClassID equals Class.ClassID
                                         select new
                                         {
                                             Teachers.LastName,
                                             Teachers.FirstName,
                                             Teachers.SecondName,
                                             Teachers.Subject,
                                             Teachers.Classroom,
                                             Teachers.DateTime,
                                             Class.Name
                                         };
                TeacherGrid.ItemsSource = TeacherGridFulling.ToList();

            }
            catch (Exception Error)
            { MessageBox.Show("Введите все обязательные параметры"); }
            Database.SaveChanges();
            TeacherGrid.ItemsSource = Database.Teachers.ToList();
        }

        private void RedactButton_Click(object sender, RoutedEventArgs e)
        {
            TeacherRedact Redact = new TeacherRedact();
            Redact.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var Clas = Database.Class.Where(item1 => item1.Name == ClassBox.Text).FirstOrDefault();
            if (TeacherMethod.AddTeacher(LastNameBox.Text, FirstNameBox.Text, MiddleNameBox.Text, Clas.ClassID,Convert.ToInt32(Classroom.Text),SubjectBox.Text,Convert.ToDateTime(DateTimeBox.Text)) == true)
            {
                LastNameBox.Clear();
                FirstNameBox.Clear();
                MiddleNameBox.Clear();
                SubjectBox.Clear();
                DateTimeBox.Clear();
                Classroom.Clear();
                ClassBox.SelectedIndex = -1;
            }
            var TeacherGridFulling = from Teachers in Database.Teachers
                                     join Class in Database.Class on Teachers.ClassID equals Class.ClassID
                                     select new
                                     {
                                         Teachers.LastName,
                                         Teachers.FirstName,
                                         Teachers.SecondName,
                                         Teachers.Subject,
                                         Teachers.Classroom,
                                         Teachers.DateTime,
                                         Class.Name
                                     };
            TeacherGrid.ItemsSource = TeacherGridFulling.ToList();
        }
        private void FormatQuestion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поле 'Дата и время' вводится в формате ГГГГ-ММ-ДД ЧЧ:ММ:СС в случае неправильного ввода будет выдана ошибка");
        }
        private void TeacherWindow1_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow MainMenu = new MainWindow();
            MainMenu.Show();
        }
    }
}
