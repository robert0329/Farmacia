using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class VentasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }
        public string MedicinaId { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
