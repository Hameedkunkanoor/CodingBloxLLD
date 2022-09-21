using CodingBloxLLD.Exceptions;
using CodingBloxLLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Repository
{
    public class UserRepository
    {
        Dictionary<string, User> _users = new Dictionary<string, User>();
        public Dictionary<string, User> Users
        {
            get => _users;
            set => _users = value;
        }

        private static UserRepository userRepository;

        public static UserRepository Instance()
        {
            if (userRepository == null)
                userRepository = new UserRepository();
            return userRepository;
        }
        public void AddUser(User user)
        {
            if (Users.ContainsKey(user.Name))
                throw new UserExistsException("User already exists");
            Users.Add(user.Name, user);
        }
        public User GetUser(string userName)
        {
            if (!Users.ContainsKey(userName))
                throw new UserNotFoundException("User not found");
            return Users[userName];
        }
    }
}
