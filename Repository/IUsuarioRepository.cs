using QuizEmdia.Model;
using System.Collections.Generic;

namespace QuizEmdia.Repository
{
    public interface IUsuarioRepository
    {
        IEnumerable<UsuarioModel> GetAll();
        UsuarioModel Find(int id);
    }
}
