using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Repository
{
    public class QuestionUserRepository : IQuestionUserRepository
    {
        private readonly QuestionUserDbContext _contexto;

        public QuestionUserRepository(QuestionUserDbContext ctx)
        {
            _contexto = ctx;
        }

        public QuestionUserModel Create(QuestionUserModel questionModel)
        {
            QuestionUserModel qm = new QuestionUserModel();
            qm.QuestionId = questionModel.QuestionId;
            qm.UsuarioId = questionModel.UsuarioId;
            qm.Response = questionModel.Response;
            _contexto.Add(qm);
            _contexto.SaveChanges();
            return _contexto.QuestionUser.LastOrDefault();
        }

        public QuestionUserModel Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuestionUserModel> GetAll()
        {
            return _contexto.QuestionUser.ToList();
        }

    }
}

