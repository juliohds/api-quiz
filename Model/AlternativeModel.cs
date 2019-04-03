using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizEmdia.Model
{
    public class AlternativeModel
    {
        [Key]
        public int AlternativeId { get; set; }
        public String Question { get; set; }
        public String Text { get; set; }
        public int QuestionId { get; set; }
        public bool Correct { get; set; }
    }
}
