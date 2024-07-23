using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UQDegreePlanner.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string? Code { get; set; }
		public string? Name{ get; set; }
		public string? Description { get; set; }
		public int Units { get; set; }

        public int? DegreeId { get; set; }

   
        public Degree? Degree { get; set; } 

    }
}

