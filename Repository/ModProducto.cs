using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class ModProducto
    {
        public static void ModificarProducto(Productos producto)
        {
            string connectionString = @"Server=DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conect = new SqlConnection(connectionString))
            {

                var query = @"UPDATE producto 

                                SET Descripciones = @Descripcion,
                                Costo = @Costo,
                                NombreUsuario = @NombreUsuario,
                                PrecioVenta = @PrecioVenta,
                                Stock = Stock
                                IdUsuario = @IdUsuario
                                WHERE Id = @Id";


                conect.Open();

                using (SqlCommand comando = new SqlCommand(query, conect))
                {
                    comando.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = producto.Id });
                    comando.Parameters.Add(new SqlParameter("@Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("@Costo", SqlDbType.Decimal) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("@PrecioVenta", SqlDbType.BigInt) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });
                    comando.ExecuteNonQuery();
                }
                conect.Close();

            }

        }
    }
}