using Microsoft.EntityFrameworkCore;

namespace QuizEmdia.Repository
{
    public class QuestionUserDbContext : DbContext
    {
        public QuestionUserDbContext(DbContextOptions<QuestionUserDbContext> options) : base(options)
        { }

        public DbSet<QuestionUserModel> QuestionUser { get; set; }
    }
}