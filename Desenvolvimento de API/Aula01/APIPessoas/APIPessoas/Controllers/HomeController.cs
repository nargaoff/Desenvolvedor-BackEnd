using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string texto = "Api funcionou";
            return Ok(texto);
        }
        [HttpGet("Home1")]
        public IActionResult Index1()
        {
            string texto = "Api funcionou 1";
            return Ok(texto);
        }
    }
}
