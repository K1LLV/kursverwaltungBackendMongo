using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [Route("/lehrbetriebe")]
    public class LehrbetriebController : BaseController<Lehrbetrieb>
    {
        public LehrbetriebController(LehrbetriebService service) : base(service) { }
    }
}
