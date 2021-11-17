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

        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "First Name cannot exceed 50 characters")]
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

        [Required]
        [Display(Name = "Session Length(hours)")]
        [Range(1, 8)]
        public int SessionLength { get; set; }

        public string Description { get; set; }
        public Venue Venue { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
    }
}
