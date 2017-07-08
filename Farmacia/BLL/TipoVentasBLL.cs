using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Farmacia.Models
{
    public class TipoVentasBLL
    {
        public static List<TipoVentas>GetLista()
        {
            var lista = new List<TipoVentas>();
            var db = new FarmaciaDb();

            lista = db.TipoVentas.ToList();

            return lista;
        }
    }
}
