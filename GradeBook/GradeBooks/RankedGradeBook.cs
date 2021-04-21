using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public virtual char GetLetterGrade(double averageGrade)
        {
            if (Student.Count<5)
                throw new InvalidOperationException("")
            
            return base.GetLetterGrade(averageGrade);
        }
}
