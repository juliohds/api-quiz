using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Model
{
    public class QuizUserModel
    {
        [Key]
        public int QuizUserId { get; set; }
        public int UsuarioId { get; set; }
        public int QuizId { get; set; }
        public bool Visible { get; set; }
    }
}
