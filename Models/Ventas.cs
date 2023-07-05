using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Ventas
    {
        public long Id { get; set; }

        public string Comentarios { get; set; }

        public Ventas()
        {
            Id = 0;
            Comentarios = string.Empty;
            
        }
    }
}