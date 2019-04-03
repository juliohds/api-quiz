using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Model
{
    public class QuizModel
    {
        [Key]
        public int QuizId { get; set; }
        public string Title { get; set; }
        public List<QuestionModel> Questions { get; set; }
        
    }
}
