using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AddressLog.Models;

namespace AddressLog.Data
{
    public class ContactBookContext : DbContext
    {
        public ContactBookContext (DbContextOptions<ContactBookContext> options)
            : base(options)
        {
        }

        public DbSet<AddressLog.Models.Name> Name { get; set; }
    }
}
