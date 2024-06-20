using Microsoft.EntityFrameworkCore;
using PergamoConsole.areas.registros.MVVM.Models;

namespace PergamoConsole.database
{
    public class PergamoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(
                $"Data Source=C:\\github-projects\\projeto-pergamo\\PergamoDesktop\\PergamoConsole\\database\\dbPergamo.db3");

        public DbSet<Pessoas> Pessoas { get; set; }
    }
}