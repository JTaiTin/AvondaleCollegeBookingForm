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
    public class DetailsModel : PageModel
    {
        private readonly Software_Assesment.Data.AvcolContext _context;

        public DetailsModel(Software_Assesment.Data.AvcolContext context)
        {
            _context = context;
        }

        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Bookings.FirstOrDefaultAsync(m => m.Id == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
