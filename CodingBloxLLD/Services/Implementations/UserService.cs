using CodingBloxLLD.Exceptions;
using CodingBloxLLD.Models;
using CodingBloxLLD.Repository;
using CodingBloxLLD.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services.Implementations
{
    public class UserService : IUserService
    {
        UserRepository userRepository;

        public UserService()
        {
            userRepository = UserRepository.Instance();
        }

        public void CreateUser(User user)
        {
            try
            {
                userRepository.AddUser(user);
            }

            catch (UserExistsException ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
        public IEnumerable<User> LeaderBoard()
        {
           return userRepository.Users.Values.OrderByDescending(user => user.Score);
        }
    }
}
