﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject2.Models
{
    public class User
    {
        //[key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public bool IsAdmin { get; set; }
        
    }
}
