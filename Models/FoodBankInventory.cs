using System.ComponentModel.DataAnnotations;

namespace CW1_MVC_Food_Bank_Website.Models
{
    public class FoodBankInventory
    {
        public string? RegistrationId { get; set; }
        public string Needs { get; set; }
        public string Number { get; set; }
        public string Excess { get; set; }

    }
}
