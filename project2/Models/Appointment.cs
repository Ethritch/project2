using System;
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
        [Required (ErrorMessage = "AppId missing")]
        public int AppointmentID { get; set; }

        [Required(ErrorMessage = "Group missing")]
        public string GroupName { get; set; }

        [Required]
        [Range(1,15, ErrorMessage = "Must enter a group size between 1-15")]
        public int GroupSize { get; set; }

        [Required(ErrorMessage = "mail missing")]
        public string Email { get; set; }

        public string Phone { get; set; }

        //Foreign Key relationship
        [Required(ErrorMessage = "TimeId missing")]
        public int TimeId { get; set; }
        public Time Time { get; set; }
    }
}
