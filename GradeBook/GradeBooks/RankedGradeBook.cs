using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name): base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked grading requires 5 students at minimum.");
            }

            var threshold = (int)Math.Ceiling(Students.Count * .2);
            var grades = Students.OrderBy(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if()
            return 'F';
        }
    }
}
