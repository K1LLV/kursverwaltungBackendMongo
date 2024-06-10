using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [Route("/lernende")]
    public class StudentController : BaseController<Student>
    {
        public StudentController(StudentsService service) : base(service) { }
    }
}
