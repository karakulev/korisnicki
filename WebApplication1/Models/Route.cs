using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string startDest { get; set; }
        [Required]
        public string endDest { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int freeSeats { get; set; }

    }
}