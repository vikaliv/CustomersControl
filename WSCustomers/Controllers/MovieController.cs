using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSCustomers.Models;

namespace WSCustomers.Controllers
{
    [Route("api/movie")]
    public class MovieController : Controller
    {
        [Produces("application/json")]
        [HttpGet("find")]
        public async Task<IActionResult> Find()
        {
            try
            {
                var movie = new Movie() { MovieId = "M01", MovieName = "Sahoo", TicketPrice = 500 };
                return Ok(movie);
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpGet("findall")]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                var movies = new List<Movie>() {
                    new Movie() { MovieId = "M01", MovieName = "Sahoo", TicketPrice = 500 },
                    new Movie() { MovieId = "M02", MovieName = "Bahuballi", TicketPrice = 300 },
                    new Movie() { MovieId = "M03", MovieName = "Sultan", TicketPrice = 200 }
                };
                return Ok(movies);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}