using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/command/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        public PlatformController() { }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test of Command Service from PlatformController (PlatformService)");
        }
    }
}
