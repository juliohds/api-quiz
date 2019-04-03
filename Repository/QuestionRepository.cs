using System.Collections.Generic;
using System.Linq;
using QuizEmdia.Model;

namespace QuizEmdia.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly QuestionDbContext _contexto;

        public QuestionRepository(QuestionDbContext ctx)
        {
            _contexto = ctx;
        }

        public QuestionModel Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<QuestionModel> GetAll()
        {
            return _contexto.Question.ToList();
        }
    }
}
