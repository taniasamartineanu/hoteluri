using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using hoteluri.Data;
using hoteluri.Models;

namespace hoteluri.Pages.Camere
{
    public class DetailsModel : PageModel
    {
        private readonly hoteluri.Data.hoteluriContext _context;

        public DetailsModel(hoteluri.Data.hoteluriContext context)
        {
            _context = context;
        }

        public Camera Camera { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camera = await _context.Camera.FirstOrDefaultAsync(m => m.CameraId == id);
            if (camera == null)
            {
                return NotFound();
            }
            else
            {
                Camera = camera;
            }
            return Page();
        }
    }
}
