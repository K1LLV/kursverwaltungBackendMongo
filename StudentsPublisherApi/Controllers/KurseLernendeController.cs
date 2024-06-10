using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [Route("/kurse_lernende")]
    public class KurseLernendeController : BaseController<KurseLernende>
    {
        public KurseLernendeController(KurseLernendeService service) : base(service) { }
    }
}
