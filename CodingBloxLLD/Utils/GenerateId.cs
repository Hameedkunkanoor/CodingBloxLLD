using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Utils
{
    public static class GenerateId
    {
        static int _id;
        static GenerateId()
        {
            _id = 1;
        }
        public static int GetId()
        {
            return _id++;
        }
    }
}
