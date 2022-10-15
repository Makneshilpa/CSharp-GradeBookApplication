using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class StandaredGradeBook : BaseGradeBook
    {
        public StandaredGradeBook(string name):base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
