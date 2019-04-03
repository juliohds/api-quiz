using QuizEmdia.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizEmdia.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _contexto;

        public UsuarioRepository(UsuarioDbContext ctx)
        {
            _contexto = ctx;
        }

        public UsuarioModel Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UsuarioModel> GetAll()
        {
            return _contexto.Usuario.ToList();
        }
    }
}
