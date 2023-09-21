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
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=hamilton-8-mycookingbook;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
