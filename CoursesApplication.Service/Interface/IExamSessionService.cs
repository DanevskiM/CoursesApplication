﻿using CoursesApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApplication.Service.Interface
{
    public interface IExamSessionService
    {
        ExamSessionSignUp GetExamSessionDetails(Guid id);
        ExamSessionSignUp CreateExamSession(Guid id);
    }
}
