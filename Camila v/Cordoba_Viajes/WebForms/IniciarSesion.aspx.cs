using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_IniciarSesion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        panel_continuar.Visible = false;
        //if (Page.User.Identity.Name != "")
        //{
        //    string name = Page.User.Identity.Name.ToString();
        //    btnLogOut.Visible = true;
        //}
        btnLogOut.Visible = true;
        
        
    }
 
    //iniciar sesion
    protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
    {

        if (Page.User.Identity.Name == "")
        {
            GestorUsuarios gu = new GestorUsuarios();
            Boolean ban = gu.iniciarSesion(Login1.UserName, Login1.Password);

            if (ban == true)
            {
                e.Authenticated = true;

                panel_continuar.Visible = true;
            }
            else
            {
                e.Authenticated = false;
                //lbl_resultado.Text = "Los datos ingresados no son correctos.. ";
                //txt_username.Text = "";
                //txt_psw.Text = "";
            }
        }
        else {
            string name = Page.User.Identity.Name.ToString(); 
            lbl_resultado.Text = "Ya hay un usuario actualmente en el sistema y se llama :" + name;
        }
        
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        System.Web.Security.FormsAuthentication.SignOut();
        Response.Redirect("IniciarSesion.aspx");
    }
}