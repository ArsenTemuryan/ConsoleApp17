using ConsoleApp17.Manager;
using ConsoleApp17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentmanager = new StudentManager();
            StudentModel[] students = studentmanager.GetStudent(63);
            TeacherManager teacherManager = new TeacherManager();
            TeacherModel[] teachers = teacherManager.GetTeacher(4);
            UnivesityManager univesity = new UnivesityManager();
            TeacherModel[] swappedteachers = univesity.SwappTeacherToStudents(teachers, students);
            StudentModel[] swappesstudents = univesity.SwappStudentToTeacher(swappedteachers, students);
        }
    }
}
