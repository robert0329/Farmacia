using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farmacia.Models
{
    public class CategoriasBLL
    {
        public static List<Categorias> GetLista()
        {
            var lista = new List<Categorias>();
            var db = new FarmaciaDb();

            lista = db.Categorias.ToList();

            return lista;
        }
    }
}
