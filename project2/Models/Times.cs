using System;
using System.ComponentModel.DataAnnotations;

namespace project2.Models
{
    public class Time
    {
      
        [Key]
        [Required]
        public int TimeId { get; set; }
        public DateTime dateTime { get; set; }
        
    }
}
