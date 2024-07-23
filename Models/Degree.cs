using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UQDegreePlanner.Models
{
	public class Degree
    {
		public int Id { get; set; }
		public string? Name { get; set; }
		public virtual List<Course> CourseList { get; set; } = new List<Course>();
	}
}

