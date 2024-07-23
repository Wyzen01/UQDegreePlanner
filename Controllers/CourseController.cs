using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UQDegreePlanner.Data;
using UQDegreePlanner.Models;

namespace UQDegreePlanner.Controllers
{
    [Route("api/course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CourseController(ApplicationDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var degrees = _context.Courses.ToList();

            return Ok(degrees);
        }


        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var degree = _context.Courses.Find(id);

            if (degree == null)
            {
                return NotFound();
            }

            return Ok(degree);
        }

        [HttpPost]
        public async Task<ActionResult<Course>> Create(Course course)
        {

            _context.Courses.Add(course);

  

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = course.Id }, course);
        }
    }
}

