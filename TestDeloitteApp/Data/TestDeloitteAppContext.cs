
using Microsoft.EntityFrameworkCore;
using TestDeloitteApp.Data;
using TestDeloitteApp.Models;
namespace TestDeloitteApp.Data;
public class TestDeloitteAppContext : DbContext
{
    public DbSet<CaseDiary> CaseDiaries { get; set; }
    public DbSet<CaseDiaryNote> CaseDiaryNotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data source=TestDeloitteApp.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }
}