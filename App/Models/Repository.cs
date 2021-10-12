using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public static class Repository
    {
        private static List<User> _users;

        static Repository()
        { //executed only once
            _users = new List<User>();
        }

        public static void AddResponse(User user)
        {
            _users.Add(user);
        }

        public static IEnumerable<User> Users => _users;
    }
}