namespace Ankieta.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Data
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [MinLength(2, ErrorMessage = "The first name must be at least 2 characters long")]
        public string? Imie { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [MinLength(2, ErrorMessage = "The last name must be at least 2 characters long")]
        public string? Nazwisko { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [MinLength(8, ErrorMessage = "The password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "The password must contain at least one uppercase letter, one lowercase letter, and a digit")]
        public string? Haslo { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [Compare("Haslo", ErrorMessage = "Passwords must match")]
        public string? PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? NrTelefonu { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Range(11, 80, ErrorMessage = "Age must be between 11 and 80")]
        public int? Wiek { get; set; }

        [Required(ErrorMessage = "Please select a city")]
        public string? Miasto { get; set; }

        public enum Miasta { Lublin, Kraków, Wrocław, Szczecin, Wieliczka }
    }
}
