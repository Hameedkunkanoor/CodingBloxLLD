using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }

        public User(string name, string email, int score)
        {
            Name = name;
            Email = email;
            Score = score;
        }
    }
}
