using CodingBloxLLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBloxLLD.Services
{
    public class UserService
    {
        Dictionary<string, User> _users = new Dictionary<string, User>();
        public Dictionary<string, User> Users
        {
            get => _users;
            set => _users = value;
        }
        public void AddUser(User user)
        {
            Users.Add(user.Name, user);
        }
        public User GetUser(string userName)
        {
            if (Users.ContainsKey(userName))
                return Users[userName];
            else
                return default(User);
        }
    }
}
