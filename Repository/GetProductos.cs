using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class GetProductos
    {
        public static List<Productos> ListarProductos()
        {

            string connectionString = @"Server =DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto WHERE Id=@pId";

            var listaProductos = new List<Productos>();

            using (SqlConnection conect = new SqlConnection(connectionString))
            {
                conect.Open();
                using (SqlCommand comando = new SqlCommand(query, conect))
                {
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "@pId";
                    parametro.DbType = DbType.Int32;
                    parametro.Value = Id;
                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            var producto = new Productos();
                            producto.Id = dr.GetInt64("Id");
                            producto.Descripcion = dr.GetString("Descripciones");
                            producto.Costo = dr.GetDecimal("Costo");
                            producto.PrecioVenta = dr.GetDecimal("PrecioVenta");
                            producto.Stock = dr.GetInt32("Stock");
                            producto.IdUsuario = dr.GetInt64("IdUsuario");
                            listaProductos.Add(producto);
                        }

                    }

                }


            }

            return listaProductos;

        }
    }
}