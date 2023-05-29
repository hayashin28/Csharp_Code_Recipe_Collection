using System;
using Microsoft.EntityFrameworkCore;
using DBSample.MD;

namespace DBSample.EF {

    public class ExampleDbContext : DbContext
    {
/*
        public void ConfigureServices(IServiceCollection services)
        {   
            services.AddDbContext<ExampleDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("ExampleDbContext")));
        }
*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=175.41.203.140; Port=5432; Username=hayashi; Password=ya53mmfe; Database=postgres01");
        }

        public DbSet<ShohinModel> shohinModel { get; set; }
    }

}