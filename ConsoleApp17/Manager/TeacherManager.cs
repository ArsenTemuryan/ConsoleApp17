using ConsoleApp17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Manager
{
   public class TeacherManager
    {
       public  TeacherModel[] GetTeacher(int count)
        {
            TeacherModel[] teachers = new TeacherModel[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                teachers[i] = new TeacherModel(rnd.Next(18, 45), $"Teacher {i}", DateTime.Now.Date, Guid.NewGuid());
            }
            return teachers;
        }
       
    }
}
