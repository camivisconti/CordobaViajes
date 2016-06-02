using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de TuPaquete
/// </summary>
public class TuPaquete
{
    public int idPAquete { get; set; }
    public int idCabania { get; set; }
    public DateTime fecha_ida { get; set; }
    public DateTime fecha_vuelta { get; set; }

	public TuPaquete()
	{

	}
}