using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApplication.Domain.Models
{
    public class CourseInExamSession : BaseEntity
    {
        public virtual Course Course { get; set; }
        public Guid CourseId { get; set; }
        public virtual ExamSessionSignUp ExamSessionSignUp { get;set;}
        public Guid ExamSessionSignUpId { get; set; }
        public int Quantity { get; set; }
    }
}
