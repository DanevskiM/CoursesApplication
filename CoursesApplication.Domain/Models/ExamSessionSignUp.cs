using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApplication.Domain.Models
{
    public class ExamSessionSignUp : BaseEntity
    {
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public CoursesApplicationUser User { get; set; }
        public ICollection<CourseInExamSession> CourseInExamSessions { get; set; }
    }
}
