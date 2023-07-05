using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class GetUsuario
    {
        public static List<Usuarios> ListarUsuarios()
        {

            string connectionString = @"Server=DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";

            var listaUsuarios = new List<Usuarios>();

            using (SqlConnection conect = new SqlConnection(connectionString))
            {
                conect.Open();
                using (SqlCommand comando = new SqlCommand(query, conect))
                {

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            var usuario = new Usuarios();
                            usuario.Id = dr.GetInt64("Id");
                            usuario.Nombre = dr.GetString("Nombre");
                            usuario.Apellido = dr.GetString("Apellido");
                            usuario.NombreUsuario = dr.GetString("NombreUsuario");
                            usuario.Password = dr.GetString("Contraseña");
                            usuario.Mail = dr.GetString("Mail");
                            listaUsuarios.Add(usuario);
                        }

                    }
                }
            }

            return listaUsuarios;

        }

}
}