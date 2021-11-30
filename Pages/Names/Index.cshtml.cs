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
    public class IndexModel : PageModel
    {
        private readonly AddressLog.Data.ContactBookContext _context;

        public IndexModel(AddressLog.Data.ContactBookContext context)
        {
            _context = context;
        }

        public IList<Name> Name { get;set; }

        public async Task OnGetAsync()
        {
            Name = await _context.Name.ToListAsync();
        }
    }
}
