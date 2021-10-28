using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Software_Assesment.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Venue { get; set; }
        public DateTime SessionTime { get; set; }
        public int SessionLength { get; set; }
        public string Description { get; set; }
    }
}
