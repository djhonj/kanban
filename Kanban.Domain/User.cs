﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Domain
{
    public class User
    {
        public User()
        {

        }

        public User(int id, string username, string password, string name, string email)
        {
            Id = id;
            UserName = username;
            Password = password;
            Name = name;
            Email = email;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
