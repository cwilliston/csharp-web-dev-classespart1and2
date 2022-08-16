using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student carolynn = new Student("Carolynn", 123456, 1, 4.0);
            Console.WriteLine($"{carolynn.Name}, ID {carolynn.StudentId}, has {carolynn.NumberOfCredits} credits and a GPA of {carolynn.Gpa}.");
        }
    }
}
