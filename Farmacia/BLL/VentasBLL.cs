﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farmacia.Models
{
    public class VentasBLL
    {
        public static bool Insertar (Ventas venta)
        {
            bool retorno = false;
            try
            {
                using (var db = new FarmaciaDb())
                {
                    db.Ventas.Add(venta);
                    db.SaveChanges();
                    retorno = true;
                }
            }catch(Exception)
            {
                throw;
            }

            return retorno;
        }
        
    }
}
