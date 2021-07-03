using ConsoleApp17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Manager
{
    public class UnivesityManager
    {
        public TeacherModel[] SwappTeacherToStudents(TeacherModel[] teacher, StudentModel[] students)
        {
            int studentCount = students.Length / teacher.Length;
            int lastTeacherStudents = students.Length % teacher.Length + studentCount;
            int lastTeacherID = teacher.Length - 1;
            for (int i = 0; i < lastTeacherID; i++)
            {
                teacher[i].students = new StudentModel[studentCount];

                for (int j = 0; j < studentCount; j++)
                {
                    teacher[i].students[j] = students[studentCount * i + j];
                }
            }
            teacher[lastTeacherID].students = new StudentModel[lastTeacherStudents];
            for (int i =0; i < lastTeacherStudents; i++)
            {
                teacher[lastTeacherID].students[i] = students[studentCount * lastTeacherID + i];
            }
            return teacher;
        }
        public StudentModel[] SwappStudentToTeacher(TeacherModel[] teacher, StudentModel[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                var idNum = students[i]._id;
                for (int j = 0; j < teacher.Length; j++)
                {
                    for (int k = 0; k < teacher[j].students.Length; k++)
                    {
                        if (idNum==teacher[j].students[k]._id)
                        {
                            students[i].teacher = teacher[j];
                        }
                    }
                }
            }
            return students;
        }
    }
}
