using System;
using System.Collections.Generic;
using System.Text;

namespace GradeStudents
{
    public class Grades
    {
        public List<float> grades2 = new List<float>();

        public void AddGrade(float grade)
        {
            grades2.Add(grade); 
        }
    }
}
