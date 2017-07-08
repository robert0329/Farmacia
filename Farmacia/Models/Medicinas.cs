using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class Medicinas
    {
        [Key]
        public int MedicinaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CantidadExistencia { get; set; }
        public int LaboratorioId { get; set; }
        public string Especificaciones { get; set; }
        public int CategoriaId { get; set; }

        public Medicinas()
        {

        }
    }
}
