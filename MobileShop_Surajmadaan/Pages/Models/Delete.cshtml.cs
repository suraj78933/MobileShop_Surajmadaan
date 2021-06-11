using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MobileShop_Surajmadaan.BussinessLayer;
using MobileShop_Surajmadaan.Data;

namespace MobileShop_Surajmadaan.Pages.Models
{
    public class DeleteModel : PageModel
    {
        private readonly MobileShop_Surajmadaan.Data.ApplicationDbContext _context;

        public DeleteModel(MobileShop_Surajmadaan.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Model Model { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model = await _context.Models.FirstOrDefaultAsync(m => m.ID == id);

            if (Model == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model = await _context.Models.FindAsync(id);

            if (Model != null)
            {
                _context.Models.Remove(Model);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
