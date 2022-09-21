using CodingBloxLLD.Exceptions;
using CodingBloxLLD.Models;
using CodingBloxLLD.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services
{
    public class UserService
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

            catch(UserExistsException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
    }
}
