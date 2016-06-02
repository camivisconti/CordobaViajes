using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    public int id_usuario { get; set; }
    public string nombre { get; set; }
    public string password { get; set; }
    public bool adm { get; set; }


	public Usuario()
	{
		
	}
}