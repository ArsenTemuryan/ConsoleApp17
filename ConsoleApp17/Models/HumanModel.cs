using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Models
{
    public class HumanModel
    {
        public int _age;
        public string _name;
        public DateTime _birthdate;
        public Guid _id;
       
       
        public HumanModel(int age, string name, DateTime birthdate, Guid id)
        {
            _age = age;
            _name = name;
            _birthdate = birthdate;
            _id = id;

        }
    }
}
