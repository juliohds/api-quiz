using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizEmdia.Model;
using QuizEmdia.Repository;

namespace QuizEmdia.Controller
{   
    [Route("api/[Controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepositorio;

        public QuestionController(IQuestionRepository _questionRepo)
        {
            _questionRepositorio = _questionRepo;
        }
        [HttpGet]
        public IEnumerable<QuestionModel> GetAll()
        {
            return _questionRepositorio.GetAll();
        }
    }
}
