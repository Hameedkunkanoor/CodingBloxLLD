using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using CodingBloxLLD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services
{
    public class ContestService  
    {

        ContestRepository contestRepository;
        UserRepository userRepository;
        public ContestService()
        {
            contestRepository = ContestRepository.Instance();
            userRepository = UserRepository.Instance();
        }
        public void CreateContest(Contest contest)
        {
            if (!userRepository.Users.TryGetValue(contest.CreaterName,out User user))
                   throw new Exception("User not found");
            contest.Attendees.Add(user);
            contestRepository.AddContest(contest);
        }

    }
}
