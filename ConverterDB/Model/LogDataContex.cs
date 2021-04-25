using Microsoft.EntityFrameworkCore;

namespace LoadDb
{
    public class LogDataContex: DbContext
    {
        public DbSet<ConvLog> ConverterLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-FII19S2;Database=KonwerterDB;Integrated Security=True");


        }

    }
}
