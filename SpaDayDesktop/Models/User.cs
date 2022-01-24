﻿using System;

namespace SpaDayDesktop.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }


        public User() { Date = DateTime.Now; }

        public User(string username, string email, string password): this()
        {
            Username = username;
            Email = email;
            Password = password;
        }
        
    }
}
