using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizEmdia.Model;

namespace QuizEmdia.Repository
{
    public class AlternativeRepository : IAlternativeRepository
    {
        private readonly AlternativeDbContext _contexto;

        public AlternativeRepository(AlternativeDbContext ctx)
        {
            _contexto = ctx;
        }

        public AlternativeModel Find(int id)
        {
            return _contexto.Alternative.FirstOrDefault(u => u.AlternativeId == id);
        }

        public IEnumerable<AlternativeModel> FindQuestionId(int id)
        {
            return _contexto.Alternative.Where(u => u.QuestionId == id).ToList();
        }

        public IEnumerable<AlternativeModel> getAll()
        {
            return _contexto.Alternative.ToList();
        }
    }
}
