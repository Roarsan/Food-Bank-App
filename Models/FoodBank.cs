using System.ComponentModel.DataAnnotations;

namespace CW1_MVC_Food_Bank_Website.Models
{
    public class FoodBank
    {
        public string? RegistrationId { get; set; }
        public string? Name { get; set; }
        public string? Ward { get; set; }
        public string? District { get; set; }
        public string? Postcode { get; set; }
        public string? Address { get; set; }
        public bool Closed { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Uri? Homepage { get; set; }
        public Uri? Self { get; set; }

    }
}
