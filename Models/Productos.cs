using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Productos
    {
        public long Id { get; set; }

        public string Descripcion { get; set; }

        public Decimal Costo { get; set; }

        public Decimal PrecioVenta { get; set; }

        public int Stock { get; set; }

        public long IdUsuario { get; set; }


        public Productos()
        {
            Id = 0;
            Descripcion = string.Empty;
            Costo = 0;
            PrecioVenta = 0;
            Stock = 0;
            IdUsuario = 0;
        }
    }
}