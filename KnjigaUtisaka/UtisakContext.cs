using Microsoft.EntityFrameworkCore;

namespace KnjigaUtisaka
{
    public class UtisakContext : DbContext
    {

        public UtisakContext(DbContextOptions<UtisakContext> options) : base(options)
        {
                
        }
        public DbSet<Utisak> Utisci { get; set; }
    }
}
