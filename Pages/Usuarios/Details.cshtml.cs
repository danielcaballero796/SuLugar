using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ParqueaderoApp.Data;
using ParqueaderoApp.Models;

namespace ParqueaderoApp.Pages.Usuarios
{
    public class DetailsModel : PageModel
    {
        private readonly ParqueaderoApp.Data.ParqueaderoAppContext _context;

        public DetailsModel(ParqueaderoApp.Data.ParqueaderoAppContext context)
        {
            _context = context;
        }

        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.Id == id);

            if (Usuario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
