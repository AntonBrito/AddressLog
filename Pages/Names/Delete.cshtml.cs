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
    public class DeleteModel : PageModel
    {
        private readonly AddressLog.Data.ContactBookContext _context;

        public DeleteModel(AddressLog.Data.ContactBookContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Name = await _context.Name.FindAsync(id);

            if (Name != null)
            {
                _context.Name.Remove(Name);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
