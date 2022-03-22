﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [Range(1,15, ErrorMessage = "Must enter a group size between 1-15")]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        //Foreign Key relationship
        [ForeignKey("Time")]
        [Required]
        public int TimeId { get; set; }
        public Time Times { get; set; }
    }
}
