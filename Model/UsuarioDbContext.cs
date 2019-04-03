using Microsoft.EntityFrameworkCore;

namespace QuizEmdia.Model
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) 
            : base(options)
        { }

        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
