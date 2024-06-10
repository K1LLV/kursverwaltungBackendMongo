using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [Route("/laender")]
    public class LandController : BaseController<Land>
    {
        public LandController(LandService service) : base(service) { }
    }
}
