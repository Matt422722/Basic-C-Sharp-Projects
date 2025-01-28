using Microsoft.EntityFrameworkCore;
using FinalChallengeCodeFirst.Models;

namespace FinalChallengeCodeFirst.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

