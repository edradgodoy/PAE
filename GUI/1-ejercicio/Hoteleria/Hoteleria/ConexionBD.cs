using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Hoteleria
{
    public class ConexionBD
    {
        // Reemplaza "tu_contraseña" con la contraseña de tu usuario root en MySQL
        private string cadenaConexion = "Server=localhost;Database=dsi;Uid=root;Pwd=;";

        public MySqlConnection AbrirConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}