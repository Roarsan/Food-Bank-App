using System.ComponentModel.DataAnnotations;

namespace CW1_MVC_Food_Bank_Website.Models
{
    public class FoodBank
    {
        public string registration_id { get; set; }
        public string name { get; set; }
        public string ward { get; set; }
        public string district { get; set; }
        public string postcode { get; set; }
        public string address { get; set; }
        public bool closed { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public Uri homepage { get; set; }
        public Uri self { get; set; }

    }
}
