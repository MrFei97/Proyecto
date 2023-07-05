using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class CrearProducto
    {
        public static double CrearProductos(Productos producto)
        {
            double IdProducto = 0;
            string connectionString = @"Server=DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conect = new SqlConnection(connectionString))
            {

                var query = @"Insert into producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario)
                                Values(@Descripciones,@Costo,@PrecioVenta,@Stock,@IdUsuario); select @@IDENTIFY";

                conect.Open();

                using (SqlCommand comando = new SqlCommand(query, conect))
                {

                    comando.Parameters.Add(new SqlParameter("@Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("@Costo", SqlDbType.Decimal) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("@PrecioVenta", SqlDbType.BigInt) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

                }
                conect.Close();

            }

            return IdProducto;



        }
    }
}