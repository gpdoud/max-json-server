using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxJsonServer.Models {

	public class MaxDbContext : DbContext {

		public MaxDbContext(DbContextOptions<MaxDbContext> options) : base(options) {
		}

		public DbSet<User> Users { get; set; }
	}
}
