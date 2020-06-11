using System;
using GradeBook.Enums;
using Newtonsoft.Json.Serialization;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook
    {
        public StandardGradeBook(string name)
        {
            
        }
        public string Type = GradeBookType.Standard;
        
        
    }
}