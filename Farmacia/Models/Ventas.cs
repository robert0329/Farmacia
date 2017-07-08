using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
     public class  Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public int TipoVentaId { get; set; }
        public string Medicina { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Total { get; set; }
        
        
        
        public Ventas()
        {

        }
      
    }
}
