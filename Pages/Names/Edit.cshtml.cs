using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AddressLog.Data;
using AddressLog.Models;

namespace AddressLog.Pages.Names
{
    public class EditModel : PageModel
    {
        private readonly AddressLog.Data.ContactBookContext _context;

        public EditModel(AddressLog.Data.ContactBookContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Name).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NameExists(Name.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NameExists(int id)
        {
            return _context.Name.Any(e => e.ID == id);
        }
    }
}
