using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Model
{
    public class AlternativeDbContext : DbContext
    {
        public AlternativeDbContext(DbContextOptions<AlternativeDbContext> options) : base(options) { }

        public DbSet<AlternativeModel> Alternative { get; set; }
    }
}
