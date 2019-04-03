using Microsoft.AspNetCore.Mvc;
using QuizEmdia.Model;
using QuizEmdia.Repository;
using System.Collections.Generic;

namespace QuizEmdia.Controller
{   
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepositorio;

        public UsuarioController(IUsuarioRepository usuarioRepo)
        {
            _usuarioRepositorio = usuarioRepo;
        }

        [HttpGet]
        public IEnumerable<UsuarioModel> GetAll()
        {
            return _usuarioRepositorio.GetAll();
        }

    }
}
