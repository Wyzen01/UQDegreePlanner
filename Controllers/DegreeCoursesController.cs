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
    [Route("api/degreeCourses")]
    [ApiController]
    public class DegreeCoursesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public DegreeCoursesController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [HttpGet("{id}")]
        public IActionResult GetByCourseId([FromRoute] int id)
        {
            var courseList = _context.Courses.Where(c => c.DegreeId == id).ToList();

            return Ok(courseList);
        }




    }
}

