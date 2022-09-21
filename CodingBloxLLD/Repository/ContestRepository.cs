using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Repository
{
    public class ContestRepository
    {
        List<Contest> _contests ;
        public List<Contest> Contests
        {
            get => _contests;
            set => _contests = value;
        }
        private static ContestRepository contestRepository;

        public static ContestRepository Instance()
        {
            if(contestRepository == null)
                contestRepository = new ContestRepository();
            return contestRepository;
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
     
    }
}
