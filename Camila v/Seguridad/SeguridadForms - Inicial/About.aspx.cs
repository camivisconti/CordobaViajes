using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Configuration;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["miCadena"].ConnectionString;
        LogicaAccesoADatos.GestorDeClientes.Grabar();
    }
}
