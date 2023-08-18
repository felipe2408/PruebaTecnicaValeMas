using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Model;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {

            _context = context;

        }



        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<Person>> Get()
        {
            var people = await _context.People.ToListAsync();

            return people;

        }



        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post(Person person)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    person.PersonID = Guid.NewGuid();
                    _context.People.Add(person);
                    _context.SaveChanges();

                    return Ok();
                }


                return NoContent();

            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

    }
}
