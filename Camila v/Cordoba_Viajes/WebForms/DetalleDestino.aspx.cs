using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_DetalleDestino : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["idDestino"] != null)
        {
            Destino d = GestorDestino.buscarPorId(Convert.ToInt32(Request.QueryString["idDetino"]));
            mostrarDatos(d);

        }
    }

    private void mostrarDatos(Destino d)
    {
        litDescripcion.Text = d.nombre;
        imgDestino.ImageUrl = string.Format("boostrap/img/{0}.jpg", d.Imagen);
    }
}