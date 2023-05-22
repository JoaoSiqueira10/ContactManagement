using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ContactManagement.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [MinLength(6)]
        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Column("Contact")]
        [Display(Name = "Contact")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Contact must be 9 digits.")]
        public string ContactNumber { get; set; }

        [Required]
        [EmailAddress]
        [Column("E-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
