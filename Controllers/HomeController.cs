
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace ielts_backend.Controllers
{
    [Route("[controller]"), ApiController, AllowAnonymous]
    public class HomeController : ControllerBase 
    { 
        [HttpGet]
        public IActionResult Echo(string message) => Ok("test");


    }
}
