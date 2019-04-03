using System.Collections.Generic;

namespace QuizEmdia.Repository
{
    public interface IQuestionUserRepository
    {
        IEnumerable<QuestionUserModel> GetAll();

        QuestionUserModel Find(int id);
        QuestionUserModel Create(QuestionUserModel questionModel);
    }
}