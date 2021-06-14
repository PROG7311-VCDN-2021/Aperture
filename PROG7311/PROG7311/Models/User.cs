using System;
using System.Collections.Generic;

#nullable disable

namespace PROG7311.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
    }
}
