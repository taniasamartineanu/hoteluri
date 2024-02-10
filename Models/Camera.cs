using System.ComponentModel.DataAnnotations;

namespace hoteluri.Models
{
    public class Camera
    {
        public int CameraId { get; set; }

        [Required(ErrorMessage = "Vă rugăm să selectați un hotel.")]
        [Display(Name = "Hotel")]
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Numărul camerei este obligatoriu.")]
        [Display(Name = "Număr cameră")]
        public string NumarCamera { get; set; }
    }
}