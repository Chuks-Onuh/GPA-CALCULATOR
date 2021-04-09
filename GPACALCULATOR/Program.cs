using System;
using System.Collections.Generic;

namespace GPACALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate your GPA with ease."); // welcome user
            Console.WriteLine();
            List<Course> courses = new List<Course>(); // initialization of List container that will hold user's input
            try
            {
                string userResponse;
                do
                {
                    Course course = new Course(); // Instantiating an object for Course class
                    // accepting user's input for cousre code, course unit and course score
                    Console.WriteLine();
                    Console.Write("Enter course: ");
                    string courseCode = Console.ReadLine().ToUpper();
                    Console.WriteLine(); // new line
                    Console.Write("Enter course unit: ");
                    int courseUnit = int.Parse(Console.ReadLine());
                    Console.WriteLine(); // new line
                    Console.Write("Enter score: ");
                    int coursescore = int.Parse(Console.ReadLine());
                    // assigning user's input to object's class.
                    course.Code = courseCode;
                    course.Unit = courseUnit;
                    course.Score = coursescore;
                    // appending user's input to list container.
                    courses.Add(course);
                    Console.Write("Do you want to enter another course? (yes/any key to quit)");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();
                } while (userResponse.ToLower() == "yes");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input");
            }
            DisplayResult(courses);
            Console.WriteLine();
            Console.WriteLine($"Your GPA is = {Static.GetGpa(courses):N2} to 2 decimal places. ");
        }

        static void DisplayResult(List<Course> courses)
        {
            Console.WriteLine($"|--------------|------------|-------|-----------|");
            Console.WriteLine($"|COURSE & CODE |COURSE UNIT | GRADE | GRADE-UNIT|");
            Console.WriteLine($"|--------------|------------|-------|-----------|");
            // looping through list container(courses) to get user inputs
            foreach (var course in courses)
            {
                Console.WriteLine($"| {course.Code, -13}| {course.Unit, -11}| {Static.Grade(course.Score), -6}| {Static.Gradepoints(Static.Grade(course.Score)), -10}|");
            }
            Console.WriteLine($"|-----------------------------------------------|");
            
        }
    }
}
