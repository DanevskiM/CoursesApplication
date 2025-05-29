using CoursesApplication.Domain.Models;
using CoursesApplication.Repository.Interface;
using CoursesApplication.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApplication.Service.Implementation
{
    public class ExamSessionService : IExamSessionService
    {
        public IRepository<ExamSessionSignUp> _examSessionSignUpRepository;
        public IRepository<CourseInExamSession> _courseInExamSessionRepository;
        public ExamSessionService _examSessionService;
        public CourseInExamSession _courseInExamSession;

        public ExamSessionService(IRepository<ExamSessionSignUp> examSessionSignUpRepository, IRepository<CourseInExamSession> courseInExamSessionRepository, ExamSessionService examSessionService, CourseInExamSession courseInExamSession)
        {
            _examSessionSignUpRepository = examSessionSignUpRepository;
            _courseInExamSessionRepository = courseInExamSessionRepository;
            _examSessionService = examSessionService;
            _courseInExamSession = courseInExamSession;
        }

        public ExamSessionSignUp CreateExamSession(Guid id)
        {
            throw new NotImplementedException();
        }

        public ExamSessionSignUp GetExamSessionDetails(Guid id)
        {
            var examSessionSignUp = _examSessionSignUpRepository.Get(
                selector: x => x,
                predicate: x => x.Id==id,
                include: x => x
                .Include(y => y.CourseInExamSessions)
                .ThenInclude(c => c.Course));

            if(examSessionSignUp==null)
            {
                throw new Exception("ExamSessionSignUp not found");
            }
            return examSessionSignUp;
        }

    }
}
