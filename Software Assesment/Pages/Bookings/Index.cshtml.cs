using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        
        public IList<Booking> bookings { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync(string sortOrder, string SearchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Booking> BookingsIQ = from s in _context.Bookings
                                             select s;
            //sorting and search filter
            if (!string.IsNullOrEmpty(SearchString))
            {
                BookingsIQ = BookingsIQ.Where(s => s.LastName.Contains(SearchString) || s.FirstName.Contains(SearchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    BookingsIQ = BookingsIQ.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    BookingsIQ = BookingsIQ.OrderBy(s => s.SessionDate);
                    break;
                case "date_desc":
                    BookingsIQ = BookingsIQ.OrderByDescending(s => s.SessionDate);
                    break;
                default:
                    BookingsIQ = BookingsIQ.OrderBy(s => s.LastName);
                    break;
            }
            bookings = await BookingsIQ.AsNoTracking().ToListAsync();
        }
    }
}