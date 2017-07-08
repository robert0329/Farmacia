using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.BLL
{
    public class VentasDetallesBLL
    {
        public static bool Insertar(List<VentasDetalle> detalles)
        {
            bool resultado = false;
            using (var db = new FarmaciaDb())
            {
                try
                {
                    foreach (VentasDetalle detail in detalles)
                    {
                        db.VentasDetalle.Add(detail);
                        db.SaveChanges();
                        resultado = true;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
    }
}
