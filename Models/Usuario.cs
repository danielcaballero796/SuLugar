using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParqueaderoApp.Models
{
    [Table("usuario")]
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Placa { get; set; }
        public string Telefono { get; set; }
        [Display(Name = "FechaIng")]
        [DataType(DataType.Date)]
        public DateTime FechaIng { get; set; }


    }
}
