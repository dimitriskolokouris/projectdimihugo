using System.ComponentModel.DataAnnotations;

namespace projectdimihugo.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Voornaam verplicht invullen")]
        public string Voornaam { get; set; } = default!;
        [Required(ErrorMessage = "Achternaam verplicht invullen")]
        public string Achternaam { get; set; } = default!;
        [EmailAddress(ErrorMessage = "Emailaddress verplicht invullen")]
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Bericht { get; set; } = default!;
    }
}
