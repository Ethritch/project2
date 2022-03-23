using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Models
{
    public class Time
    {
        [Key]
        [Required]
        public int TimeId { get; set; }

        public DateTime AppointmentTime { get; set; }

        public bool taken { get; set; }
    }
}
