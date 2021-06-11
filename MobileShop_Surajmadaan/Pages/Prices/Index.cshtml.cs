using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MobileShop_Surajmadaan.BussinessLayer;
using MobileShop_Surajmadaan.Data;

namespace MobileShop_Surajmadaan.Pages.Prices
{
    public class IndexModel : PageModel
    {
        private readonly MobileShop_Surajmadaan.Data.ApplicationDbContext _context;

        public IndexModel(MobileShop_Surajmadaan.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Price> Price { get;set; }

        public async Task OnGetAsync()
        {
            Price = await _context.Prices.ToListAsync();
        }
    }
}
