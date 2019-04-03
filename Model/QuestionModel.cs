using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Model
{
    public class QuestionModel
    {
        [Key]
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int QuizId { get; set; }      
        public List<AlternativeModel> Alternatives { get; set; }
    }
}
