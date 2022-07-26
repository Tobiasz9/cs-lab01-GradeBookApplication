﻿using GradeBook.Enums;
using GradeBook.GradeBooks;


namespace GradeBook.GradeBooks { 
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}
