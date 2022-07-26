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
            var studentsTwentyPercent = Math.Ceiling(0.2 * Students.Count);
            var higherAverageGradeStudents = 0;

            foreach (var student in Students)
            {

                if (student.AverageGrade > averageGrade)
                {
                    higherAverageGradeStudents++;
                }

            }
            var downGrade = (int)Math.Floor(higherAverageGradeStudents / studentsTwentyPercent);
            var gradeToLetter = new List<char> { 'A', 'B','C', 'D', 'E', 'F' };
            return gradeToLetter[downGrade];
        }


    }
}
