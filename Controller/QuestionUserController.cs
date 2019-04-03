using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizEmdia.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizEmdia.Controller
{
    [Route("api/[Controller]")]
    public class QuestionUserController : ControllerBase
    {
        private readonly IQuestionUserRepository _questionUserRepositorio;

        public QuestionUserController(IQuestionUserRepository _questionUserRepo)
        {
            _questionUserRepositorio = _questionUserRepo;
        }

        [HttpGet]
        public IEnumerable<QuestionUserModel> getAll()
        {
            return _questionUserRepositorio.GetAll();
        }
        [HttpPost]
        public QuestionUserModel create([FromBody] QuestionUserModel questionModel)
        {
            return _questionUserRepositorio.Create(questionModel);
        }
    }
}
