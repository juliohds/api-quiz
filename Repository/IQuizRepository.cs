using QuizEmdia.Model;
using QuizEmdia.View;
using System.Collections.Generic;

namespace QuizEmdia.Repository
{
    public interface IQuizRepository
    {
        IEnumerable<QuizModelView> GetAll();

        QuizModelView Find(int id);

        QuizModelView FindWithQuestion(int id);

        QuizModelView FindWithUser(int idQuiz, int idUser);
        
    }
}
