using System;
using System.Collections.Generic;
using System.Text;

namespace GPACALCULATOR
{
    class Static
    {
        // method that returns course grade based on course score
        public static char Grade(int score)
        {
            if (score > 69)
            {
                return 'A';
            }
            else if (score > 59)
            {
                return 'B';
            }
            else if (score > 49)
            {
                return 'C';
            }
            else if (score > 44)
            {
                return 'D';
            }
            else if (score > 39)
            {
                return 'E';
            }
            else
            {
                return 'F';
            }

        }
        // method that returns grade points base on grade
        public static int Gradepoints(char grade)
        {
            switch (grade)
            {
                case 'A':
                    return 5;
                case 'B':
                    return 4;
                case 'C':
                    return 3;
                case 'D':
                    return 2;
                case 'E':
                    return 1;
                default:
                    return 0;
            }
        }
        // method that calculate gpa
        public static decimal GetGpa(List<Course> course)
        {
            int totalQualityPoint = 0;
            int totalCourseUnit = 0;
            decimal gpa = 0;

            for (int i = 0; i < course.Count; i++)
            {
                totalQualityPoint += course[i].Unit * Gradepoints(Grade(course[i].Score));
                totalCourseUnit += course[i].Unit;
            }
            // calculating gpa and casting totalQualityPoint to double
            try
            {
                gpa = (decimal)totalQualityPoint / totalCourseUnit;
            }
            catch (Exception)
            {

                Console.WriteLine("An error occured");
            }
            return gpa;
        }
    }
}

