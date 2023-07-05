using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public static class GetVentas
    {
        public static List<Ventas> ListarVentas()
        {

            string connectionString = @"Server =DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, Comentarios FROM Venta";

            var listaVentas = new List<Ventas>();

            using (SqlConnection conect = new SqlConnection(connectionString))
            {
                conect.Open();
                using (SqlCommand comando = new SqlCommand(query, conect))
                {

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            var Ventas = new Ventas();
                            Ventas.Id = dr.GetInt64("Id");
                            Ventas.Comentarios = dr.GetString("Comentarios");

                            listaVentas.Add(Ventas);
                        }

                    }

                }


            }

            return listaVentas;

        }
    }
}