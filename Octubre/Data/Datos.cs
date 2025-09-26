using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Octubre.Data
{
    internal class Datos
    {
        private string connectionString = 
            "Host=localhost;Username=admin;Password=luis;" +
            "Database=Octubre";
        private NpgsqlConnection GetConnection()
        {
            try
            {
                NpgsqlConnection connection =
                    new NpgsqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al " +
                    "conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

        public bool TestConnection()
        {
            try {
                using (var connection = GetConnection())
                {
                    if (connection != null && connection.State == 
                        System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Conexión exitosa a la base de datos.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al probar la conexión: " + ex.Message);
                return false;
            }
        }
    }
}
