using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Models
{
   public class StudentModel:HumanModel
    {
        public TeacherModel teacher;
        public StudentModel(int age,string name,DateTime birthdate,Guid id): base(age,name,birthdate,id)
        {
                
        }
    }
}
