using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hoteluri.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Numele clientului este obligatoriu.")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "Prenumele clientului este obligatoriu.")]
        public string Prenume { get; set; }

/*        public List<Rezervare> Rezervari { get; set; } = new List<Rezervare>();
*/    }
}
