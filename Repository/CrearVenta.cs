using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class CrearVenta
    {
        public static double CrearVenta(Ventas ventas)
        {
            double IdVenta = 0;
            string connectionString = @"Server=DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conect = new SqlConnection(connectionString))
            {

                var query = @"Insert into Venta (Comentarios)
                                Values(@Comentarios); select @@IDENTIFY";

                conect.Open();

                using (SqlCommand comando = new SqlCommand(query, conect))
                {
                    comando.Parameters.Add(new SqlParameter("@Comentarios", SqlDbType.VarChar) { Value = ventas.Comentarios });



                }
                conect.Close();

            }

            return IdVenta;



        }
    }
}