using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Software_Assesment.Data;
using Software_Assesment.Models;

namespace Software_Assesment.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly Software_Assesment.Data.AvcolContext _context;

        public IndexModel(Software_Assesment.Data.AvcolContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking.ToListAsync();
        }
    }
}
