using System;
using System.ComponentModel.DataAnnotations;

namespace hoteluri.Models
{
    public class Rezervare
    {
        public int RezervareId { get; set; }

        [Required(ErrorMessage = "Selectați un client.")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Required(ErrorMessage = "Selectați un hotel.")]
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        [Required(ErrorMessage = "Selectați o cameră.")]
        public int CameraId { get; set; }
        public Camera Camera { get; set; }

        [Required(ErrorMessage = "Data check-in este obligatorie.")]
        [DataType(DataType.Date)]
        public DateTime DataCheckIn { get; set; }

        [Required(ErrorMessage = "Data check-out este obligatorie.")]
        [DataType(DataType.Date)]
        public DateTime DataCheckOut { get; set; }
    }
}
