using Microsoft.EntityFrameworkCore;

namespace ExamNguyenTuanKiet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Phim> Phims { get; set; }
    }
}
