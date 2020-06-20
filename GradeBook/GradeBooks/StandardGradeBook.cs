using System;
using GradeBook.Enums;
using Newtonsoft.Json.Serialization;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
        }


    }
}