using QuizEmdia.Model;
using System.Collections.Generic;

namespace QuizEmdia.View
{
    public class QuestionModelView
    {       
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int QuizId { get; set; }
        public string UserResponse { get; set; }
        public List<AlternativeModel> Alternatives { get; set; }
    }
}