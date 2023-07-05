using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class InicioSesion
    {

        public static Usuarios IniciarSesion(string NombreUsuario, string password)
        {
            string connectionString = @"Server=DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            using (var connection = new SqlConnection(connectionString))
            {

                connection.Open();

                const string query = @"SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario
                   WHERE NombreUsuario = @NombreUsuario AND Contraseña = @password";

                using (var command = new SqlCommand(query, connection))

                {

                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);

                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())

                    {
                        if (reader.Read())

                        {

                            return new Usuarios

                            {

                                Id = reader.GetInt64(0),

                                Nombre = reader.GetString(1),

                                Apellido = reader.GetString(2),

                                NombreUsuario = reader.GetString(3),

                                Password = reader.GetString(4),

                                mail = reader.GetString(5)

                            };

                        }

                        else

                        {

                            return null;

                        }

                    }

                }

            }

        }
    }
}