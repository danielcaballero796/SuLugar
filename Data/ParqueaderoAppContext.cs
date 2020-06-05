using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParqueaderoApp.Models;

namespace ParqueaderoApp.Data
{
    public class ParqueaderoAppContext : DbContext
    {
        public ParqueaderoAppContext (DbContextOptions<ParqueaderoAppContext> options)
            : base(options)
        {
        }

        public DbSet<ParqueaderoApp.Models.Usuario> Usuario { get; set; }
    }
}
