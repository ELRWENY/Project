using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public String ? Email { get; set; }
        public string ? Adress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
