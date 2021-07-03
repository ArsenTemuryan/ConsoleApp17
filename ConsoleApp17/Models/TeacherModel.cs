using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Models
{
    public class TeacherModel : HumanModel
    {
        public StudentModel[] students;
        public TeacherModel(int age,string name,DateTime birthdate,Guid id):base(age,name,birthdate,id)
        {

        }
    }
    
}
