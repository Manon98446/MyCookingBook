using Microsoft.EntityFrameworkCore;

namespace CookBook.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            const string connectionString = "server=188.166.24.55;database=hamilton-8-mycookingbook;user id=hamilton-8-mycookingbookuser;password=72GNZwH3msoBzvl9";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
            optionsBuilder.UseMySql(connectionString, serverVersion);

        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
