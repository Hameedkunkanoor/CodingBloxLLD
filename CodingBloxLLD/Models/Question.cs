using CodingBloxLLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Models
{
    public class Question : BaseModel
    {
        public string Title { get; set; }
        public QuestionTypeEnum Type { get; set; }
        public int Score { get; set; }
    }
}
