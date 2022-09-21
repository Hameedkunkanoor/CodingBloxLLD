using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services.Interfaces
{
    public interface IQuestionService
    {
        void CreateQuestion(Question question);
        IEnumerable<Question> ListQuestion(QuestionLevelEnum typeEnum);
    }
}
