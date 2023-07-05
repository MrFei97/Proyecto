using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    public class VentasController : Controller
    {
        // GET: Ventas
        [HttpGet]
        public List<Ventas> GetVenta()
        {
            return GetVentas.ListarVentas();
        }

        [HttpPost]
        public double PostVentas(Ventas NuevoVenta)
        {
          return  CrearVenta.CrearVenta(NuevoVenta);
        }
    }
}