using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;

namespace CapadeNegocio
{
    public class Negocio
    {
        ConexionBD con = new ConexionBD();

        //Metodos para el Login
        public int ConexionSQL(String Usuario, String contrasena)
        {
            return con.validarUsuario(Usuario, contrasena);

        }

        //consultar productos

        public DataTable consultaCN()
        {
            return con.consulta();
        }

        public DataTable consultaUsuarios() 
        {
            return con.consultaUsuarios();
        }
        
        public void insertarProductosCN(int Codigo_producto, String Descripcion_producto, int cantidad, int Precio_unitario)
        {
            con.insertarProductos(Codigo_producto, Descripcion_producto, cantidad, Precio_unitario);
        }

        //Metodos del formulario de registro
        public void crearUsuarioCN(String nombre, String apellido, String nombreUsuario,
            String contrasena, String rol)
        {
            con.crearUsuario(nombre, apellido, nombreUsuario, contrasena, rol);
        }
        
    }
}
