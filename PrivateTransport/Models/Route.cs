using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateTransport.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Start Destination")]
        public string startDest { get; set; }
        [Required]
        [Display(Name = "End Destination")]
        public string endDest { get; set; }
        public int UserID { get; set; }
        [Required]
        [Display(Name = "Price")]
        [Range(0, 100000)]
        public int price { get; set; }
        [Required]
        [Display(Name = "Free Seats")]
        [Range(0, 50)]
        public int freeSeats { get; set; }
    }
}