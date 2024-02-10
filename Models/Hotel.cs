using System.ComponentModel.DataAnnotations;

namespace hoteluri.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Numele hotelului este obligatoriu.")]
        public string NumeHotel { get; set; }

        [Required(ErrorMessage = "Locația hotelului este obligatorie.")]
        public string Locatie { get; set; }
        public List<Camera> Camere { get; set; } = new List<Camera>();

    }
}
