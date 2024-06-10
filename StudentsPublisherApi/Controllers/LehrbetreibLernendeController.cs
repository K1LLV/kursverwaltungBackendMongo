using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [Route("/lehrbetrieb_lernende")]
    public class LehrbetriebLernendeController : BaseController<LehrbetriebLernende>
    {
        public LehrbetriebLernendeController(LehrbetriebLernendeService service) : base(service) { }
    }
}
