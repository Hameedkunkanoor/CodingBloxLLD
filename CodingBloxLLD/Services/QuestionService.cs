using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using CodingBloxLLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services
{
    public class QuestionService
    {
        List<Question> _questions = new List<Question>();
        public List<Question> Questions
        {
            get => _questions;
            set => _questions = value;
        }
        public void AddQuestion(Question question)
        {
            question.QuestionId = GenerateId.GetId();
            Questions.Add(question);
        }
        public IEnumerable<Question> GetQuestions(QuestionTypeEnum? typeEnum)
        {
            if(typeEnum.Equals(QuestionTypeEnum.All))
            {
                return Questions;
            }
            return Questions.Where(x => x.Type == typeEnum);
        }
    }
}
