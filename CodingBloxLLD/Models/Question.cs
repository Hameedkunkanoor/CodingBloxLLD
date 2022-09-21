using CodingBloxLLD.Enums;
using CodingBloxLLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Models
{
    public class Question 
    {
        public int Id { get => GenerateId.GetId(); }
        public string Title { get; set; }
        public QuestionLevelEnum Type { get; set; }
        public int Score { get; set; }

        public Question(string title, QuestionLevelEnum type, int score)
        {
            Title = title;
            Type = type;
            Score = score;
        }
    }
}
