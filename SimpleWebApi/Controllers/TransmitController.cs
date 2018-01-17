using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SimpleWebApi.Models;

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TransmitController : Controller
    {
        private readonly InfoOptions _infoOptions;

        public TransmitController(IOptions<InfoOptions> optionAccessor)
        {
            _infoOptions = optionAccessor.Value;
        }
        [HttpPost]
        public IActionResult Post([FromBody]Packet packet)
        {
            _infoOptions.InputGps = packet.Packet1;
            return Content(_infoOptions.InputGps);
        }
    }
}