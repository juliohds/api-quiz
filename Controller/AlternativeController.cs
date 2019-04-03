using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizEmdia.Model;
using QuizEmdia.Repository;

namespace QuizEmdia.Controller
{
    [Route("api/[Controller]")]
    public class AlternativeController : ControllerBase
    {
        private readonly IAlternativeRepository _alternativeRepositorio;

        public AlternativeController(IAlternativeRepository _alternativeRepo)
        {
            _alternativeRepositorio = _alternativeRepo;
        }

        [HttpGet]
        public IEnumerable<AlternativeModel> getAll()
        {
            return _alternativeRepositorio.getAll();
        }

        [HttpGet("{id}")]
        public AlternativeModel Find(int id)
        {
            return _alternativeRepositorio.Find(id);
        }

        [HttpGet("question/{id}")]
        public IEnumerable<AlternativeModel> FindQuestionId(int id)
        {
            return _alternativeRepositorio.FindQuestionId(id);
        }
    }
}
