﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class ProductosVendidos
    {

        public long Id { get; set; }

        public int Stock { get; set; }

        public long IdProducto { get; set; }

        public long IdVenta { get; set; }

        public ProductosVendidos()
        {
            Id = 0;
            Stock = 0;
            IdProducto = 0;
            IdVenta = 0;

        }
    }
}