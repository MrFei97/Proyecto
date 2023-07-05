using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class ModUsuario
    {
        public static bool ModificarUsuario(Usuarios usuario)
        {
            string connectionString = @"Server=DESKTOP-0MNSSFT\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conect = new SqlConnection(connectionString))
            {

                var query = @"UPDATE usuario 

                                SET Nombre = @Nombre,
                                Apellido = @Apellido,
                                NombreUsuario = @NombreUsuario,
                                Contraseña = @Password,
                                Mail = mail
                                WHERE Id = @Id";


                conect.Open();

                using (SqlCommand comando = new SqlCommand(query, conect))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = usuario.Id });
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Password", SqlDbType.VarChar) { Value = usuario.Password });
                    comando.Parameters.Add(new SqlParameter("mail", SqlDbType.VarChar) { Value = usuario.Mail });
                    comando.ExecuteNonQuery();
                }
                conect.Close();

            }

            return true;

        }

    }
}