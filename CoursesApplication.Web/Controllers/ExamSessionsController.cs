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
            // TODO: Implement method
            // Create ViewModel/DTO with list of all the courses in the session and the TotalCount or pass it through ViewData/ViewBag
            throw new NotImplementedException();
        }
    }
}
