using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UQDegreePlanner.Models; 
using UQDegreePlanner.Controllers;
using Microsoft.Extensions.Hosting;

namespace UQDegreePlanner.Data
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{
		}

		public DbSet<Course> Courses { get; set; }

		public DbSet<Degree> Degrees { get; set; }

   
    }
    
}

