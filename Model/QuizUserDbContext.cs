using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Model
{
    public class QuizUserDbContext : DbContext
    {
        public QuizUserDbContext(DbContextOptions<QuizUserDbContext> options) : base (options)
        { }

        public DbSet<QuizUserModel> QuizUser { get; set; }
    }
}

