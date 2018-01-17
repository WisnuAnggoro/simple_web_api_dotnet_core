using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SimpleWebApi.Models;

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ReceiveController : Controller
    {
        private readonly InfoOptions _infoOptions;

        public ReceiveController(IOptions<InfoOptions> optionAccessor)
        {
            _infoOptions = optionAccessor.Value;
        }

        [HttpGet]
        public string Get()
        {
            return _infoOptions.InputGps;
        }
    }
}