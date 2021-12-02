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
    public class StudentMethod
    {
        Database Database = new Database();
        public bool RedactStudent(int StudID, string LastName, string FirstName, string SecondName, int Class)
        {
            var Student = Database.Students.Where(item => item.StudentID == StudID).FirstOrDefault();
            try
            {              
                Student.LastName = LastName;
                Student.FirstName = FirstName;
                Student.SecondName = SecondName;
                Student.ClassID = Class;
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
        public bool AddStudent(string LastName, string FirstName, string SecondName, int Class)
        {
            Database Database = new Database();
            Students Student = new Students();
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
                Student.LastName = LastName;
                Student.FirstName = FirstName;
                Student.SecondName = SecondName;
                Student.ClassID = Class;
                Database.Students.Add(Student);
                Database.SaveChanges();
                MessageBox.Show("Ученик успешно добавлен добавлен");
            }
            catch(Exception Error)
            {
                MessageBox.Show("Введите корректные значения. "+Error);
                return false;
            }
            return true;
        }
        public bool DeleteStudent(int StudID)
        {
            Database Database = new Database();
            try
            {
                
                var StudentVar = Database.Students.Where(item => item.StudentID == StudID).FirstOrDefault();
                if (StudentVar== null)
                {
                    MessageBox.Show("Вы не выбрали строку. "+StudentVar);
                    return false;
                }
                else
                {
                    Database.Students.Remove(StudentVar);
                    Database.SaveChanges();
                    MessageBox.Show("Ученик удалён");
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