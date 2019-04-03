using QuizEmdia.Model;
using QuizEmdia.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Repository
{
    public class QuizRepository : IQuizRepository
    {
        private readonly QuizDbContext _contextoQuiz;
        private readonly QuestionDbContext _contextoQuestion;
        private readonly AlternativeDbContext _contextoAlternative;
        private readonly QuestionUserDbContext _contextoQuestionUser;

        public QuizRepository(QuizDbContext ctxQuiz, QuestionDbContext ctxQuestion, AlternativeDbContext ctxAlternative, QuestionUserDbContext ctxQuestionUser)
        {
            _contextoQuiz = ctxQuiz;
            _contextoQuestion = ctxQuestion;
            _contextoAlternative = ctxAlternative;
            _contextoQuestionUser = ctxQuestionUser;
        }

        public QuizModelView Find(int id)
        {     
            return FindWithQuestion(id);
        }
        
        public IEnumerable<QuizModelView> GetAll()
        {
            List<QuizModelView> lista = new List<QuizModelView>();

            foreach (var item in _contextoQuiz.Quiz.ToList())
            {
                lista.Add(FindWithQuestion(item.QuizId));
            }
            return lista;
        }

        public QuizModelView FindWithUser(int id, int idUser)
        {
            return FindWithUserAnswers(id, idUser);
        }

        private QuizModelView FindWithUserAnswers(int idQuiz, int idUser)
        {
            QuizModelView quiz = FindWithQuestion(idQuiz);
            quiz.Questions.ForEach(q => q
           .UserResponse = _contextoQuestionUser.QuestionUser
           .Where(u => u.UsuarioId == idUser && u.QuestionId == q.QuestionId).FirstOrDefault().Response.ToString());
            return quiz;
        }

        public QuizModelView FindWithQuestion(int id)
        {
            QuizModelView quiz = ConvertToQuizModelView(_contextoQuiz.Quiz.FirstOrDefault(u => u.QuizId == id));
            quiz.Questions = ConvertToQuestionModelView(_contextoQuestion.Question.Where(u => u.QuizId == quiz.QuizId).ToList());
            quiz.Questions
                .ForEach(x => x.Alternatives = _contextoAlternative.Alternative.Where(y => y.QuestionId == x.QuestionId).ToList());
            return quiz;
        }
        
        public QuizModelView ConvertToQuizModelView(QuizModel quizModel)
        {
            QuizModelView quizModelView = new QuizModelView();
            quizModelView.QuizId = quizModel.QuizId;
            quizModelView.Title = quizModel.Title;                               
            return quizModelView;
        }

        public List<QuestionModelView> ConvertToQuestionModelView(List<QuestionModel> listQuestionModel)
        {
            List<QuestionModelView> listQuestionModelView = new List<QuestionModelView>();
            foreach(var q in listQuestionModel) {
                QuestionModelView questionModelView = new QuestionModelView();
                questionModelView.QuizId = q.QuizId;
                questionModelView.QuestionId = q.QuestionId;
                questionModelView.Title = q.Title;                
                questionModelView.Description = q.Description;
                questionModelView.Alternatives = q.Alternatives;
                listQuestionModelView.Add(questionModelView);
            }
            return listQuestionModelView;
        }

    }
}
