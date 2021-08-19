using Microsoft.AspNetCore.Mvc;

namespace Soft.CalculoJuros.API.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public string Get() =>
            "https://github.com/rafaelbitencourt/Soft.CalculoJuros";
    }
}
