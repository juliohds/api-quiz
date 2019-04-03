using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizEmdia.Model;
using QuizEmdia.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizEmdia.Controller
{
    [Route("api/[Controller]")]
    public class QuizUserController : ControllerBase
    {
        private readonly IQuizUserRepository _quizUserRepositorio;

        public QuizUserController(IQuizUserRepository quizUserRepo)
        {
            _quizUserRepositorio = quizUserRepo;
        }

        [HttpGet]
        public IEnumerable<QuizUserModel> GetAll()
        {
            return _quizUserRepositorio.GetAll();
        }
    }
}

