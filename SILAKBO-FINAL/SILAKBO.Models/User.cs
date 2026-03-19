using System;
using System.Collections.Generic;
using System.Text;

namespace SILAKBO_FINAL.SILAKBO.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // hashed
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Role { get; set; }
    }
}
