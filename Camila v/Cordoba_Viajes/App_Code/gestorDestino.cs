using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Descripción breve de gestorDestino
/// </summary>
public class GestorDestino
{
	public GestorDestino()
	{
	}

    static string  cadenaConexion = ConfigurationManager.ConnectionStrings["CordobaViajess"].ConnectionString;

    
    public static List<Destino> buscarTodos()
    {
        List<Destino> listaD = new List<Destino>();
        SqlConnection cn = new SqlConnection(cadenaConexion);
        Destino c2 = null;
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Connection = cn;
            cmd.CommandText = "select l.id_localidad as ID, l.nombre as nombreLocalidad, p.nombre as nombrePais from Localidad l join Pais p on  (l.id_pais = p.id_pais)";
            //cmd.CommandType = CommandType.Text; // es necesario setear esta propiedad el valor por defecto es  CommandType.Text
            SqlDataReader dr = cmd.ExecuteReader();

            // con el resultado cargar una entidad
            while (dr.Read())
            {
                c2 = new Destino();
                c2.idDestino = (int)dr["ID"];
                c2.nombre = (string)dr["nombreLocalidad"];
                c2.nombre = dr["nombreLocalidad"].ToString();
                c2.pais= (string)dr["nombrePais"];
                c2.pais = dr["nombrePais"].ToString();
                c2.Imagen = dr["ID"].ToString();

                listaD.Add(c2);
            }
            dr.Close();

        }

        catch (Exception)
        {
            throw;
        }

        finally
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }

        return listaD;
    }
    public static void Grabar(Destino entidad)
    { 

        string nombre = entidad.nombre;
        int idDestino = entidad.idDestino;
        int idPais = entidad.idPais;

        
        SqlConnection cn = new SqlConnection(cadenaConexion);


        entidad = buscarPorId(entidad.idDestino);

        try
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Connection = cn;

            if (entidad == null)
            {
                cmd.CommandText = "insert into Localidad (nombre, id_pais) values (@nombre, @idPais)";                
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@id_pais", idPais));
            }
            else
            {
                cmd.CommandText = "update Localidad set (nombre = @nombre)";
                cmd.Parameters.Add(new SqlParameter("@codigo", idDestino));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@id_pais", idPais));
            }

            SqlDataReader dr = cmd.ExecuteReader();

        }
        catch (Exception)
        {
            throw;
        }


        finally
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
    }


    public static Destino buscarPorId(int id_localidad)
    {

        
        SqlConnection cn = new SqlConnection(cadenaConexion);
        Destino d = null;
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Localidad where id_localidad = @id_localidad"; 
            cmd.Parameters.Add(new SqlParameter("@id_localidad", id_localidad));
            //cmd.CommandType = CommandType.Text; // es necesario setear esta propiedad el valor por defecto es  CommandType.Text
            SqlDataReader dr = cmd.ExecuteReader();
            // con el resultado cargar una entidad

            if (dr.Read())
            {
                d = new Destino();
                if (dr["id_localidad"] != DBNull.Value)
                    d.idDestino = (int)dr["id_localidad"];
                    d.nombre = dr["nombre"].ToString();

            }
            dr.Close();
        }

        catch (Exception)
        {
            throw;
        }

        finally
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }

        return d;
    }

    public static List<Destino> BuscarPorNombre(string nombre, string orden)
    {
        List<Destino> listaHotel = new List<Destino>();

        
        SqlConnection cn = new SqlConnection(cadenaConexion);
        Destino d2 = null;

        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Localidad where nombre like @nombre order by " + orden; 
            cmd.Parameters.Add(new SqlParameter("@nombre", "%" + nombre + "%"));
            
            SqlDataReader dr = cmd.ExecuteReader();

            // con el resultado cargar una entidad
            while (dr.Read())
            {

                d2 = new Destino();
                d2.nombre = (string)dr["nombre"];
                d2.nombre = dr["nombre"].ToString();
                d2.idDestino = (int)dr["id_localidad"];
               
                listaHotel.Add(d2);
            }
            dr.Close();

        }

        catch (Exception)
        {
            throw;
        }

        finally
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }

        return listaHotel;
    }



    public static System.Data.DataTable ObtenerTodos()
    {

        
        SqlConnection cn = new SqlConnection(cadenaConexion);

        DataTable dt = new DataTable();
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Connection = cn;

            cmd.CommandText = "select * from Pais";
            dt.Load(cmd.ExecuteReader());


        }
        catch (Exception)
        {
            throw;
        }

        finally
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
        return dt;
    }

}