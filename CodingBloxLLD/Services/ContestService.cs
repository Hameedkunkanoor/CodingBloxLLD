using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services
{
    public class ContestService  
    {
     /*   Dictionary<string, Dictionary<string,Contest>> _users = new Dictionary<string, User>();
        public Dictionary<string, User> Users
        {
            get => _users;
            set => _users = value;*/
        
        List<Contest> _contests = new List<Contest>();
        public List<Contest> Contests
        {
            get => _contests;
            set => _contests = value;
        }
        public void AddContest(Contest contest)
        {
            Contests.Add(contest);
        }
        public IEnumerable<Contest> GetContests(ContestLevelEnum contestLevel)
        {
            if (contestLevel.Equals(ContestLevelEnum.All))
            {
                return Contests;
            }
            return Contests.Where(x => x.ContestLevel == contestLevel);
        }
        public bool AttendContest(int contestId,string userName)
        {
           Contests.Where(x => x.Id == contestId)
                .FirstOrDefault()
                .Attendees.Add(UserService);
        }

    }
}
