using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneBookList.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(15)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Company { get; set; }
    }
}
