using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Text.Json;
using System.Threading.Tasks; //Fra Google. Vet ikke hva den gjør.
using Test_3.Models;

namespace Test_3.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        // GET: api/users
        // https://localhost:7272/api/users
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.GetAllUsers());
        }

        // GET: api/users/5
        // https://localhost:7272/api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var users = _context.GetAllUsers();
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) 
                return NotFound();
            return Ok(user);
        }

        // lag et endepunkt for å slette en spesifikk bruker

        // lag et endepunkt for å opprette en ny bruker
        // https:localhost:7272/api/users
        //DateTime now = new DateTime();
        User testuser = new User(50, "APItest", "API@API.com", "APIpassword", DateTime.Now);

        /*[Htst(Name = "AddUser")] [tpPo] Postman klager
        public IActionResult AddUser([FromBody] CreateUserDto dto)
        {
            var user = new User
            {
                username = dto.Username,
                email = dto.Email,
                password = dto.Password, //burde hashes?
                created_at = DateTime.UtcNow
            };

            int newId = _context.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = newId }, new { id = newId });
        }*/

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] JsonElement json)
        {
            try
            {
                //if (json == null)
                 //   return BadRequest("User is null.");
                User user = JsonSerializer.Deserialize<User>(json);
                int newId = await _context.AddUsers(user);
                user.Id = newId;

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // lag et endepunkt for å endre informasjonen til en bruker
    }
}
