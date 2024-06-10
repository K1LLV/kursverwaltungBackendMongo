using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [Route("/kurse")]
    public class KursController : BaseController<Kurs>
    {
        public KursController(KursService service) : base(service) { }
    }
}
