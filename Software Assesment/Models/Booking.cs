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
        public int Id { get; set; }

        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Session Date")]
        [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; }
        [Display(Name = "Session Time")]
        [DataType(DataType.Time)]
        public DateTime SessionTime { get; set; }
        [Display(Name = "Session Length(hours)")]
        public int SessionLength { get; set; }
        public string Description { get; set; }
        public Venue Venue { get; set; }
    }
}
