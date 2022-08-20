using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Course
    {
        public List<Student> students = new List<Student>();
        public string teacher;
        public string courseName;


        public override string ToString()
        {
            return "Course: " + courseName + ", Teacher: " + teacher;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            Course course = obj as Course;
            return (course.teacher == teacher && course.courseName == courseName);
        }
    }
}
