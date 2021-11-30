using System;
using System.Collections.Generic;


namespace AddressLog.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }

}