using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Exceptions
{
    public class ContestNotFoundException : Exception
    {
        public ContestNotFoundException(string message) : base(message)
        {
        }
    }
}
