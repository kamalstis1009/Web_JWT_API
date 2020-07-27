using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_JWT_API.Models
{
    public class Authenticate
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Username { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
    }
}
