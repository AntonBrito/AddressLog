using System.ComponentModel.DataAnnotations;

namespace AddressLog.Models
{
    public enum PhoneNumber
    {

    }
    public class Contact
    {
        
        public int ContactID { get; set; }
        public int NameID { get; set; }
        public string AddressID { get; set; }
        [DisplayFormat(NullDisplayText = "No PhoneNumber")]
        public PhoneNumber? PhoneNumber { get; set; }

        public Name Name { get; set; }
        public Address Address { get; set; }

    }
 }