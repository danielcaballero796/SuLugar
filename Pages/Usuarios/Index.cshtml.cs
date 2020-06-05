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
    public class IndexModel : PageModel
    {
        private readonly ParqueaderoApp.Data.ParqueaderoAppContext _context;

        public IndexModel(ParqueaderoApp.Data.ParqueaderoAppContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }

        public async Task OnGetAsync()
        {
            Usuario = await _context.Usuario.ToListAsync();
        }
    }
}
