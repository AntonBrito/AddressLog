using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AddressLog.Data;
using AddressLog.Models;

namespace AddressLog.Pages.Names
{
    public class DetailsModel : PageModel
    {
        private readonly AddressLog.Data.ContactBookContext _context;

        public DetailsModel(AddressLog.Data.ContactBookContext context)
        {
            _context = context;
        }

        public Name Name { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Name = await _context.Name.FirstOrDefaultAsync(m => m.ID == id);

            if (Name == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
