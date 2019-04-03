using QuizEmdia.Model;
using System.Collections.Generic;

namespace QuizEmdia.Repository
{
    public interface IQuestionRepository
    {
        IEnumerable<QuestionModel> GetAll();

        QuestionModel Find(int id);
    }
}