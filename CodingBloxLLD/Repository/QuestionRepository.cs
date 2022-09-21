using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using CodingBloxLLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Repository
{
    public class QuestionRepository
    {
        List<Question> _questions = new List<Question>();
        public List<Question> Questions
        {
            get => _questions;
            set => _questions = value;
        }
        private static QuestionRepository questionRepository;

        public static QuestionRepository Instance()
        {
            if (questionRepository == null)
                questionRepository = new QuestionRepository();
            return questionRepository;
        }
        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        public IEnumerable<Question> GetQuestions(QuestionLevelEnum typeEnum)
        {
            if (typeEnum.Equals(QuestionLevelEnum.All))
            {
                return Questions;
            }
            return Questions.Where(x => x.Type == typeEnum);
        }
    }
}
