using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    public class ProductosVendidosController : Controller
    {
        // GET: ProductosVendidos
        [HttpGet]
        public List<ProductosVendidos> GetProductosVendido()
        {
            return GetProductosVendidos.ListarProductosVendidos();
        }
    }
}