using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ProjectWeek.Models
{
    public class User
    {
        public int userId { get; set; }
        [Required]
        public string userEmail { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}