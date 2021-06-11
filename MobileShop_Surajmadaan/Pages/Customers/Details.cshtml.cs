using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MobileShop_Surajmadaan.BussinessLayer;
using MobileShop_Surajmadaan.Data;

namespace MobileShop_Surajmadaan.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly MobileShop_Surajmadaan.Data.ApplicationDbContext _context;

        public DetailsModel(MobileShop_Surajmadaan.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers
                .Include(c => c.Model)
                .Include(c => c.Price).FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
