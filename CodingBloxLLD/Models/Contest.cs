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
        public string Name { get; set; }
        public ContestLevelEnum ContestLevel { get; set; }
        public string CreaterName { get; set; }
        public List<User> Attendees { get; set; }
        public ContestStatusEnum ContestStatus { get; set; }
    }
}
