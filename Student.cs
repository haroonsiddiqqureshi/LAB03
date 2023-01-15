using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student
    {
        public string Name { get; set; }

        public string Student_id { get; set; }

        public string Birth_year { get; set; }

        public string Height { get; set; }

        public double Grade { get; set; }

        public string Branch{ get; set; }

        public Student(string name, string student_id, string birth_year, string height, double grade, string branch)
        {
            Name = name;
            Student_id = student_id;
            Birth_year = birth_year;
            Height = height;
            Grade = grade;
            Branch = branch;
        }
    }

}
        
