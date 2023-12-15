using Microsoft.EntityFrameworkCore;
using NET_6._0_CRUD_API_Project_Structure.Entities;

namespace NET_6._0_CRUD_API_Project_Structure.Helpers
{
    public class DataContext :DbContext
    {
        protected readonly IConfiguration configuration;
        public DataContext(IConfiguration configuration)
        {
            configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseInMemoryDatabase("TestDb");
        }

        public DbSet<User> Users { get; set; }  
    }
}
