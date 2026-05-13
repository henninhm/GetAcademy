using Microsoft.AspNetCore.Mvc;
using Test_2.Models;
namespace Test_2.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        /*[HttpGet(Name = "GetAllUsers")]
        public IActionResult Index()
        {
            UserContext context = HttpContext.RequestServices.GetService(typeof(UserContext)) as UserContext;
            /*var result = context.GetAllUsers();
            return Ok(result);
        }*/
    }
}