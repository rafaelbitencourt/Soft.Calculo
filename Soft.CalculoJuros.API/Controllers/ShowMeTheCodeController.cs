using Microsoft.AspNetCore.Mvc;

namespace Soft.CalculoJuros.API.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public ContentResult Get() =>
            Content("https://github.com/rafaelbitencourt/Soft.CalculoJuros");
    }
}
