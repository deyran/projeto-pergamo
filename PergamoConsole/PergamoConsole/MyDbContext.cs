namespace PergamoConsole
{
    public class MyDbContext : DBContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dbPergamo.db;");
        }
    }
}