using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class GetProductosVendidos
    {
        public static List<ProductosVendidos> ListarProductosVendidos()
        {

            string connectionString = @"Server =DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido";

            var listaProductosVendidos = new List<ProductosVendidos>();

            using (SqlConnection conect = new SqlConnection(connectionString))
            {
                conect.Open();
                using (SqlCommand comando = new SqlCommand(query, conect))
                {

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            var productoVendido = new ProductosVendidos();
                            productoVendido.Id = dr.GetInt64("Id");
                            productoVendido.Stock = dr.GetInt32("Stock");
                            productoVendido.IdProducto = dr.GetInt64("IdProducto");
                            productoVendido.IdVenta = dr.GetInt64("IdVenta");
                            listaProductosVendidos.Add(productoVendido);
                        }

                    }

                }


            }

            return listaProductosVendidos;

        }
    }
}