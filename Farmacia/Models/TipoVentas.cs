using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class TipoVentas
    {
        [Key]
        public int TipoVentaId { get; set; }
        public string Descripcion { get; set; }
    }
}
