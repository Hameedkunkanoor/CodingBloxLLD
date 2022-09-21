using CodingBloxLLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Models
{
    public class Contest : BaseModel
    {
        private static int _id;
        static Contest()
        {
            _id = 1;
        }
        private static int GetId()
        {
            return _id++;
        }
        public string Name { get; set; }
        public ContestLevelEnum ContestLevel { get; set; }
        public string CreaterName { get; set; }
        public List<User> Attendees { get; set; }
        public ContestStatusEnum ContestStatus { get; set; }

        public Contest(string name, ContestLevelEnum contestLevel, string createrName)
        {
            Name = name;
            ContestLevel = contestLevel;
            CreaterName = createrName;
            ContestStatus = ContestStatusEnum.Active;
            Id = GetId();
        }
    }
}
