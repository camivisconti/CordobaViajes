using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_DestinosMundoCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
        
        rptDestinos.DataSource = GestorDestino.buscarTodos();
        rptDestinos.DataBind();
    }

    protected void rptDestinos_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int idDestino = (int)e.CommandArgument;

        Destino des = GestorDestino.buscarPorId(idDestino);
        if (e.CommandName == "Seleccionar") { }

    }
}