using System.ComponentModel.DataAnnotations;

namespace CustomerApp.Server.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }

        public ICollection<Phone> PhoneNumbers { get; set; }

        public ICollection<Email> Emails { get; set; }
        public ICollection<CustomerAddress> Addresses { get; set; }

        // PhoneNumber? - 0-n
        // Email? - 0-n
        // Age (function)
        // Birthdate* - 1-1
        // Address? 

    }
}
