
using Microsoft.AspNetCore.Mvc;
using QuizEmdia.Model;
using QuizEmdia.Repository;
using QuizEmdia.View;
using System.Collections.Generic;

namespace QuizEmdia.Controller
{
    [Route("api/[Controller]")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _quizRepositorio;

        public QuizController(IQuizRepository quizRepo)
        {
            _quizRepositorio = quizRepo;
        }

        [HttpGet]
        public IEnumerable<QuizModelView> GetAll()
        {
            return _quizRepositorio.GetAll();
        }

        [HttpGet("{id}")]
        public QuizModelView GetById(int id)
        {
            return _quizRepositorio.Find(id);
        }

        [HttpGet("{id}/user/{idUser}")]
        public QuizModelView FindWithUser(int id, int idUser)
        {            
            return _quizRepositorio.FindWithUser(id, idUser);
        }


    }
}
