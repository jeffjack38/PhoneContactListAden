using System.ComponentModel.DataAnnotations;


namespace PhoneContactListAden.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(20)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number: xxx-xxx-xxxx")]
        [StringLength(12)]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        [StringLength(40)]
        public string? Address { get; set; }

        [StringLength(30)]
        public string? Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + PhoneNumber?.Replace(" ", "-");

    }
}
