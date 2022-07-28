using GradeBook.Enums;
using GradeBook.GradeBooks;


namespace GradeBook.GradeBooks { 
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}
