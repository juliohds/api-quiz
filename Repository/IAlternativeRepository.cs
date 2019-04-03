using QuizEmdia.Model;
using System.Collections.Generic;

namespace QuizEmdia.Repository
{
    public interface IAlternativeRepository
    {
        IEnumerable<AlternativeModel> getAll();

        AlternativeModel Find(int id);

        IEnumerable<AlternativeModel> FindQuestionId(int id); 

    }
}