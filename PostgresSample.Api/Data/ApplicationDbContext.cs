using Microsoft.EntityFrameworkCore;
using PostgresSample.Api.Models;

namespace PostgresSample.Api.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Person> People { get; set; }
	}
}
