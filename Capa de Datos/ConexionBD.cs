using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeSoporte.Cache;

namespace CapadeDatos
{
    public class ConexionBD
    {
        static string conexionstring = "server= JOSECANELOPC ; database= Inventario ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        //Validaciòn de usuarios y permisos

        public int validarUsuario(string Usuario, string contrasena)
        {
            int contador;
            conexion.Open();
            string query = "Select * FROM Usuarios WHERE " +
                "nombre_usuario = '" + Usuario + "' AND contrasena = '" + contrasena + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CacheUsuario.rol = reader.GetString(4);
                }
                if (CacheUsuario.rol == "Administrador")
                {
                    conexion.Close();
                    return contador = 1;
                }
                else
                {
                    conexion.Close();
                    return contador = 2;
                }
            }
            else
            {
                conexion.Close();
                return contador = 3;
            }
        }

        //Consultas con y sin parametros

        public DataTable consulta()
        {
            conexion.Open();
            string query = "Select * from PRODUCTOS";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public DataTable consultaUsuarios()
        {
            conexion.Open();
            string query = "Select nombre, apellido, nombre_usuario, roll_de_usuario from Usuarios";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        // Insertar prodcutos con Store Procedure

        public void insertarProductos(int Codigo_producto, String Descripcion_producto, int cantidad, int Precio_unitario)
        {
            conexion.Open();
            string cadena = "exec sp_InsertarProductos '"+ Codigo_producto +"', '"+ Descripcion_producto +"', '"+ cantidad +"', " +
                "'"+ Precio_unitario +"'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        //Metodo para el Registro de Usuarios
        public void crearUsuario(String nombre, String apellido, String nombre_usuario,
            String contrasena, String rol)
        {
            conexion.Open();
            string Query = "INSERT INTO Usuarios VALUES " +
                "('" + nombre + "','" + apellido + "','" + nombre_usuario + "'," +
                "'" + contrasena + "', '" + rol + "')";
            SqlCommand comando = new SqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}