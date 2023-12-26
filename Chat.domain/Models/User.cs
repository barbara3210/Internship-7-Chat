﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public int PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
    }
}
