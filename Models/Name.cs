using System;
using System.Collections.Generic;

namespace AddressLog.Models
{
    public class Name
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}