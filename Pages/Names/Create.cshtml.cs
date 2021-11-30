using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AddressLog.Data;
using AddressLog.Models;

namespace AddressLog.Pages.Names
{
    public class CreateModel : PageModel
    {
        private readonly AddressLog.Data.ContactBookContext _context;

        public CreateModel(AddressLog.Data.ContactBookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Name Name { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Name.Add(Name);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
