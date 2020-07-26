using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_JWT_API.Models
{
    public class Product
    {
        [Key]
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(250)]
        public string ProductName { get; set; }
        [Required]
        public int ProductQty { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        [Required]
        [MaxLength(25)]
        public string CreatedAt { get; set; } = (DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss.ffff");

    }
}
