using QuizEmdia.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizEmdia.View
{
    public class QuizModelView
    {
        [Key]
        public int QuizId { get; set; }
        public string Title { get; set; }        
        public List<QuestionModelView> Questions { get; set; }        
    }
}
