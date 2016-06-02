using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de GestorUsuarios
/// </summary>
public class GestorUsuarios
{

	public GestorUsuarios()
	{
	}

    public Boolean iniciarSesion(string nombre, string contra) 
    {
        Usuario user = buscarPorNombre(nombre);

        if (user != null && user.password == contra)
        {

            return true;
        }
        else
        {
            return false;
        }

    }
    public static Usuario buscarPorNombre(string nombre)
    {
        Usuario user = null;

        string cadenaConexion = ConfigurationManager.ConnectionStrings["CordobaViajess"].ConnectionString;
        
       
        SqlConnection cn = new SqlConnection(cadenaConexion);
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Usuarios where nombre_usuario= @nombre";
            cmd.Parameters.Add("@nombre", nombre);
            //cmd.CommandType = CommandType.Text; // es necesario setear esta propiedad el valor por defecto es  CommandType.Text
            SqlDataReader dr = cmd.ExecuteReader();

            // con el resultado cargar una entidad
            while (dr.Read())
            {
                user = new Usuario();
                user.nombre = (string)dr["nombre_usuario"];
                user.nombre = dr["nombre_usuario"].ToString();
                user.password = (string) dr["clave"];
                user.password= dr["clave"].ToString();
                user.id_usuario= (int) dr["id_usuario"];
                if (Convert.ToInt32(dr["administrador"]) == 1) { user.adm = true; }
                else { user.adm = false; }

            }
            dr.Close();

        }

        catch (Exception)
        {
            throw;
        }

        finally
        {
            if (cn != null && cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }

        return user;
    }
    
    public static string[] ObtenerRoles(string nombreUsuario)
    {
        Usuario u = new Usuario();
        u = buscarPorNombre(nombreUsuario);

        if (u.adm == true) { return new string[] { "administradores" }; }
        else { return new string[] { "clientes" }; }
    }


}