using Microsoft.EntityFrameworkCore;
using PassIn.Infrastructure.Entities;
namespace PassIn.Infrastructure
{
    public class PassInDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; } //representa a tabela Events do banco de dados
        public DbSet<Attendee> Attendees { get; set; } //representa a tabela Attendees no banco de dados
        public DbSet<CheckIn> CheckIns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //config do banco de dados
        {
            optionsBuilder.UseSqlite("Data Source =C:\\Users\\neand\\Desktop\\Database\\PassInDb.db");
        }
    }
}
