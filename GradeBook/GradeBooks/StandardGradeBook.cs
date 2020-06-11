using System;
using GradeBook.Enums;
using Newtonsoft.Json.Serialization;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }


    }
}