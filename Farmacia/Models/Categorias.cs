using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
    }
}
