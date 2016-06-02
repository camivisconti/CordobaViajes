using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_DestinosMundo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (User.IsInRole("administradores")) {
            panelAdministrador.Visible = true;
            panelClientes.Visible = false;
        }
            
        else
            {
                panelAdministrador.Visible = false;
                panelClientes.Visible = true;
            }
            
    }
}