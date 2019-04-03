using QuizEmdia.Model;
using System.Collections.Generic;

namespace QuizEmdia.Repository
{
    public interface IQuizUserRepository
    {
        IEnumerable<QuizUserModel> GetAll();

        QuizUserModel Find(int id);

    }
}
