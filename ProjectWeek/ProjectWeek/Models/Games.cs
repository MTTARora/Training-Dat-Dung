using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeek.Models
{
    public class Games
    {
        public int Id { get; set; }
        [Required] [Key]
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}