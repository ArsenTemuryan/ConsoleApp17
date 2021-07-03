using ConsoleApp17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Manager
{
    public class StudentManager
    {
        public StudentModel[] GetStudent(int count)
        {
            StudentModel[] students = new StudentModel[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                students[i] = new StudentModel(rnd.Next(18, 50), $"Student {i}", DateTime.Now.Date, Guid.NewGuid());
            }
            return students;
        }
    }
}
