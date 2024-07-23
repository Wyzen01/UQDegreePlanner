using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UQDegreePlanner.Data;

namespace UQDegreePlanner.Controllers
{
    [Route("api/degree")]
    [ApiController]
    public class DegreeController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public DegreeController(ApplicationDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var degrees = _context.Degrees.ToList();

            return Ok(degrees);
        }


        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var degree = _context.Degrees.Find(id);

            if(degree == null)
            {
                return NotFound();
            }

            return Ok(degree);
        }
    }
}

