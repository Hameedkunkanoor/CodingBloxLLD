using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using CodingBloxLLD.Repository;
using CodingBloxLLD.Services.Interfaces;
using CodingBloxLLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services.Implementations
{
    public class QuestionService : IQuestionService
    {
        QuestionRepository questionRepository;

        public QuestionService()
        {
            questionRepository = QuestionRepository.Instance();
        }

        public void CreateQuestion(Question question)
        {
            questionRepository.AddQuestion(question);
        }
        public IEnumerable<Question> ListQuestion(QuestionLevelEnum typeEnum)
        {
            return questionRepository.GetQuestions(typeEnum);
        }


    }
}
