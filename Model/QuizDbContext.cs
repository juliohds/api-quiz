using Microsoft.EntityFrameworkCore;

namespace QuizEmdia.Model
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        { }

        public DbSet<QuizModel> Quiz { get; set; }
    }
}
