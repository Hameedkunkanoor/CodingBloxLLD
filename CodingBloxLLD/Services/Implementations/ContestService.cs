using CodingBloxLLD.Enums;
using CodingBloxLLD.Exceptions;
using CodingBloxLLD.Models;
using CodingBloxLLD.Repository;
using CodingBloxLLD.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services.Implementations
{
    public class ContestService : IContestService
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
            if (!userRepository.Users.TryGetValue(contest.CreaterName, out User user))
                throw new Exception("User not found");
            contest.Attendees.Add(user);
            contestRepository.AddContest(contest);
        }

        public IEnumerable<Contest> ListContest(ContestLevelEnum typeEnum)
        {
            return contestRepository.GetContests(typeEnum);
        }

        public void AttendContest(int contestId, string userName)
        {
            if (userRepository.Users.ContainsKey(userName))
                throw new UserNotFoundException("User not found");
            else if (contestRepository.GetContests(ContestLevelEnum.All)
                .ToList()
                .Exists(x => x.Id == contestId))
                throw new ContestNotFoundException("Contest not found");
            contestRepository.AddAttendee(contestId, userName);
        }

        public void RunContest(int contestId, string creatorUserName)
        {
            throw new NotImplementedException();
        }
    }
}
