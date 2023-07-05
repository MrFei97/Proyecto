using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        [HttpGet]
        public List<Usuarios> GetUsuarios()
        {
            return GetUsuario.ListarUsuarios();
        }

        [HttpPut]
        public bool PutUsuario(Usuarios usuario)
        {
            return ModUsuario.ModificarUsuario(usuario);
        }

    }

}