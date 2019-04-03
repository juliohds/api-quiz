

using Microsoft.EntityFrameworkCore;

namespace QuizEmdia.Model
{
    public class QuestionDbContext : DbContext
    {

        public QuestionDbContext(DbContextOptions<QuestionDbContext> options) : base(options)
        { }

        public DbSet<QuestionModel> Question { get; set; }

    }
}
