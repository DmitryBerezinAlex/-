using System;
using System.IO;
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
    class TeacherMethod
    {
        Database Database = new Database();
        public bool RedactTeacher(int TeacherID, string LastName, string FirstName, string SecondName, int Class,int Classroom,string Subject,DateTime date)
        {
            var Teacher = Database.Teachers.Where(item => item.TeacherID == TeacherID).FirstOrDefault();
            try
            {
                Teacher.LastName = LastName;
                Teacher.FirstName = FirstName;
                Teacher.SecondName = SecondName;
                Teacher.ClassID = Class;
                Teacher.Classroom = Classroom;
                Teacher.Subject = Subject;
                Teacher.DateTime = date;
                Database.SaveChanges();
                MessageBox.Show("Запись успешно отредактирована!");
            }
            catch (Exception Error)
            {

                MessageBox.Show("Введите корректные данные в поля!");
                return false;
            }

            return true;
        }
        public bool AddTeacher(string LastName, string FirstName, string SecondName, int Class, int Classroom, string Subject,DateTime dateTime)
        {
            Database Database = new Database();
            Teachers Teacher = new Teachers();
            try
            {
                if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(SecondName))
                {
                    MessageBox.Show("Заполнены не все поля.");
                    return false;
                }
                else if (Class == null)
                {
                    MessageBox.Show("Вы не выбрали класс");
                    return false;
                }
                Teacher.LastName = LastName;
                Teacher.FirstName = FirstName;
                Teacher.SecondName = SecondName;
                Teacher.ClassID = Class;
                Teacher.Classroom = Classroom;
                Teacher.Subject = Subject;
                Teacher.DateTime = dateTime;
                Database.Teachers.Add(Teacher);
                Database.SaveChanges();
                MessageBox.Show("Учитель успешно добавлен добавлен");
            }
            catch (Exception Error)
            {
                MessageBox.Show("Введите корректные значения. " + Error);
                return false;
            }
            return true;
        }
        public bool DeleteTeacher(int TeacherID)
        {
            Database Database = new Database();
            try
            {

                var TeacherVar = Database.Teachers.Where(item => item.TeacherID == TeacherID).FirstOrDefault();
                if (TeacherVar == null)
                {
                    MessageBox.Show("Вы не выбрали строку. " + TeacherVar);
                    return false;
                }
                else
                {
                    Database.Teachers.Remove(TeacherVar);
                    Database.SaveChanges();
                    MessageBox.Show("Учитель удалён");
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные значения.");
                return false;
            }
            return true;
        }
    }
}
