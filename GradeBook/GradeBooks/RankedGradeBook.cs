using System;
using System.Collections.Generic;
using GradeBook.Enums;


namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            base.Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)

        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            var studentsTwentyPercent = 0.2 * Students.Count;
            var higherAverageGradeStudents =  0;
            var downGrade = 0;
            foreach (var student in Students)
            {

                if (student.AverageGrade > averageGrade)
                {
                    higherAverageGradeStudents++;
                    if (higherAverageGradeStudents == studentsTwentyPercent)
                    {
                        downGrade++;
                        higherAverageGradeStudents = 0;
                    }
                }


            }
            var gradeToLetter = new List<char> { 'A', 'B','C', 'D', 'F' };
            return gradeToLetter[downGrade];
        }
        public override void CalculateStatistics()

        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;

            }
            else if (Students.Count >= 5)
            {
               
                base.CalculateStatistics();
                return;
            }

        }

    }
}
