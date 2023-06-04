using System.ComponentModel.DataAnnotations;

namespace projectdimihugo.Models
{
    public class Person
    {
        [Required]
        public string Voornaam { get; set; } = default!;
        [Required]
        public string Achternaam { get; set; } = default!;
        [Required]
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Bericht { get; set; } = default!;
    }
}
