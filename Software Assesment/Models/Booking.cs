using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Software_Assesment.Models
{

    public enum Venue
    {
        Halberg, Mills, SquashCourt1, SquashCourt2, ActivityRoom, HockeyTurf, HockeyPavilion
    }

    public class Booking
    {

        public Booking()
        {
            
        }
        public int Id { get; set; }
        //will only accept values less than 50
        [Required]
        [StringLength(50)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Session Date")]
        [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; }

        [Required]
        [Display(Name = "Session Time")]
        [DataType(DataType.Time)]
        public DateTime SessionTime { get; set; }
        //will only accept numbers from 1 - 8
        [Required]
        [Display(Name = "Session Length(hours)")]
        [Range(1, 8)]
        public int SessionLength { get; set; }

        public string Description { get; set; }

        [Required]
        public Venue Venue { get; set; }
        //will only accept input that matches phone number format
        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
    }
}
