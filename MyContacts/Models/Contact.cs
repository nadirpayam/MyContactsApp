using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı girin!")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen soyadınızı girin!")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen numaranızı girin!")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen mailinizi girin!")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen bir kategoryi seçin!")]
        public int? CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        public DateTime DateAdded { get; set; }

        public string Slug => FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
