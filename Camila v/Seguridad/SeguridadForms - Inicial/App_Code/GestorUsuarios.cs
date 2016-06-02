using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de BuscarEnBaseDatos
/// </summary>
public class GestorUsuarios 
{
    public static bool VerificarUsuarioClave(string usuario, string clave)
    {
        // aqui iria codigo que verificaria si el usuario y clave existe en la base de datos;
        if (usuario.ToLower() == "admin" && clave == "123") return true;
        if (usuario.ToLower() == "cliente" && clave == "123") return true;
        return false;
   } 

    public static string[] ObtenerRoles(string usuario)
    {
        // aqui iria el codigo que buscaria los roles del usuario en la base de datos 
        switch (usuario.ToLower())
        {
            case "admin":
                return new string[] { "administradores" };
            case "cliente":
                return new string[] { "clientes" };
            default:
                return new string[] { "" };
        }
    }
}