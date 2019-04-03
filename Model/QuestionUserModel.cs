using System.ComponentModel.DataAnnotations;

namespace QuizEmdia.Repository
{
    public partial class QuestionUserModel
    {

        [Key]
        public int QuestionUserId { get; set; }
        public int QuestionId { get; set; }
        public int UsuarioId { get; set; }
        public string Response { get; set; }
    }
}

