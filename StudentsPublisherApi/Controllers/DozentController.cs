using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [Route("/dozenten")]
    public class DozentController : BaseController<Dozent>
    {
        public DozentController(DozentService service) : base(service) { }
    }
}
