using Microsoft.EntityFrameworkCore;

namespace SQLite_DBOperations.Models.DataAccessLayer
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Students> Students { get; set; }
    }
}
