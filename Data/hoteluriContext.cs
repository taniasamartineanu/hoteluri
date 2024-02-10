using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hoteluri.Models;

namespace hoteluri.Data
{
    public class hoteluriContext : DbContext
    {
        public hoteluriContext (DbContextOptions<hoteluriContext> options)
            : base(options)
        {
        }

        public DbSet<hoteluri.Models.Hotel> Hotel { get; set; } = default!;
/*        public DbSet<hoteluri.Models.Camera> Camera { get; set; } = default!;
*/      public DbSet<hoteluri.Models.Client> Client { get; set; } = default!;
        public DbSet<hoteluri.Models.Camera> Camera { get; set; } = default!;
        public DbSet<hoteluri.Models.Rezervare> Rezervare { get; set; } = default!;
/*        public DbSet<hoteluri.Models.Rezervare> Rezervare { get; set; } = default!;
*/    }
}
