using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        [HttpGet]
        public List<Productos> GetProducto()
        {
            return GetProductos.ListarProductos();
        }

        [HttpPost]
        public double PostProducto(Productos NuevoProducto)
        {
           return CrearProducto.CrearProductos(NuevoProducto);
        }

        [HttpPut]
        public void PutProducto(Productos producto)
        {
           ModProducto.ModificarProducto(producto);
        }


        [HttpDelete]
        public void Delete([FromBody] int Id)
        {

        }

    }

}
