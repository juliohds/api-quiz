using System;
using System.ComponentModel.DataAnnotations;

namespace QuizEmdia.Model
{
    public class UsuarioModel
    {
        [Key]
        public int UsuarioId { get; set; }

        public String Nome { get; set; }

        public String Senha { get; set; }

        public String Email { get; set; }
    }
}
