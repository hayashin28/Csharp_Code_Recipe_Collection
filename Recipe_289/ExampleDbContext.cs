using Microsoft.EntityFrameworkCore;

namespace Recipe_289
{

	public class ExampleDbContext : DbContext
	{
		public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
			: base(options)
		{
		}

		// public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }

	}
}