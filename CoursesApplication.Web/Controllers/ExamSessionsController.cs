using CoursesApplication.Domain.Models;
using CoursesApplication.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CoursesApplication.Web.Controllers
{
    public class ExamSessionsController : Controller
    {
        private readonly IExamSessionService _examSessionService;

        public ExamSessionsController(IExamSessionService examSessionService)
        {
            _examSessionService = examSessionService;
        }

        // GET: ExamSessions/Details/5
        public IActionResult Details(Guid id)
        {
            var examSession = _examSessionService.GetExamSessionDetails(id);
            if (examSession == null)
                return NotFound();
            return View(examSession);
        }
    }
}
