using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizEmdia.Model;

namespace QuizEmdia.Repository
{
    public class QuizUserRepository : IQuizUserRepository
    {

        private readonly QuizUserDbContext _contexto;

        public QuizUserRepository(QuizUserDbContext ctx)
        {
            _contexto = ctx;
        }

        public QuizUserModel Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuizUserModel> GetAll()
        {
            return _contexto.QuizUser.ToList();
        }
    }
}
