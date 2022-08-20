using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; } = 0;
        public double Gpa { get; set; } = 0.0;

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId) : this(name, studentId, 0, 0) { }

        public Student(string name) : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public string GetGradeLevel(int credits)
        {
            if (credits <= 29)
            {
                return "Freshman";
            } 
            else if (credits <= 59)
            {
                return "Sophomore";
            } 
            else if (credits <= 89)
            {
                return "Junior";
            }
            else { return "Senior"; }
        }

        public void AddGrade (int credits, double grade)
        {
            double qualityScore = Gpa * NumberOfCredits;
            qualityScore += grade * credits;
            NumberOfCredits += credits;
            Gpa = qualityScore / NumberOfCredits;

        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + " , GPA: " + Gpa + ")";
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

            Student student = obj as Student;
            return student.StudentId == StudentId;
        }
    }
}
