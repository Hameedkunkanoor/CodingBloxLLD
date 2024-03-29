﻿using CodingBloxLLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services.Interfaces
{
    public interface IUserService
    {
        void CreateUser(User user);
        IEnumerable<User> LeaderBoard();
    }
}
