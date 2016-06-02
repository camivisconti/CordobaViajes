using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string nombreUsuario = User.Identity.Name;
    }
}


//TODO 01 Modificar web.config,  indicando que usa autenticacion por formularios y cuales son las paginas de login y la pagina inicial
//dentro de <configuration><system.web>
/*
     <authentication mode="Forms">
      <forms defaultUrl="Inicio.aspx" loginUrl="Login.aspx" />
    </authentication>

 */

//TODO 02 Agregar pagina Login.aspx
/*  Agregar control Login y su evento por defecto Login1_Authenticate
protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (GestorUsuarios.VerificarUsuarioClave(Login1.UserName, Login1.Password))
        {
            e.Authenticated = true;  // genera cookie de seguridad con datos del usuario (sin los roles)
        }
        else
        {
            e.Authenticated = false;

        }
    }
*/

//TODO 03 Recuperar en cada Request roles de usuario: en el global.asax agregar plantilla para el evento...
/*
    protected void Application_AuthenticateRequest(object sender, EventArgs e)
    {
        if (HttpContext.Current.User != null)
            {
                var id = HttpContext.Current.User.Identity;
                HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(id, GestorUsuarios.ObtenerRoles(id.Name));
            }
    }
 * /

//TODO 04 Modificar web.config (dentro de la seccion <configuration><system.web>), establecer la  autorizacion por defecto para todos los recursos (paginas, imagenes, scripts, etc)
/*
     <!--Esta configuracion deniega el acceso a todas la paginas (y otros recursos:archivos, imagenes, etc) a todos los usuarios anonimos (no logueados)-->
    <authorization>
      <deny users="?"/>
    </authorization>
*/



//TODO 05 Modificar web.config (dentro de la seccion <configuration>), agregar excepciones a la autorizacion por defecto para cada recurso (paginas, imagenes, scripts) o carpetas
/*
  <!--Esta configuracion permite el acceso a esta pagina a los usuarios anonimos (no logueados)-->
  <location path="Inicio.aspx">
    <system.web>
      <authorization>
        <allow users="?"/>
      </authorization>
    </system.web>
  </location>

  <!--Cuidado! que tambien se autoriza o deniega el acceso a imagenes, scripts, etc. (a todos los archivos y/o carpetas)--> 
  <!--esta configuracion permite acceso anonimo a la carpeta imagenes--> 
  <location path="imagenes">    
    <system.web>
      <authorization>
        <allow users="?"/>
      </authorization>
    </system.web>
  </location>
  <location path="js">    
    <system.web>
      <authorization>
        <allow users="?"/>
      </authorization>
    </system.web>
  </location>
   <location path="css">    
    <system.web>
      <authorization>
        <allow users="?"/>
      </authorization>
    </system.web>
  </location>

  <location path="VentasContado.aspx">
    <system.web>
      <authorization>
        <allow roles="clientes"/>
      </authorization>
    </system.web>
  </location>

  <location path="VentasCredito.aspx">
    <system.web>
      <authorization>
        <allow roles="administradores,clientes"/>
      </authorization>
    </system.web>
  </location>
 
*/


//TODO 06a Modificar en pagina maestra el navbar de bootstrap agregandole runat='server' e Id='mnuCliente'
/*
            <li runat="server" id="mnuVentasContado"><a href="/VentasContado.aspx">Ventas Contado</a></li>
            <li runat="server" id="mnuVentasCredito"><a href="/VentasCredito.aspx">Ventas Credito</a></li>
            <li runat="server" id="mnuConfiguracionesSitio"><a href="/ConfiguracionesSitio.aspx">Configuraciones Sitio</a></li>
*/


//TODO 06b Modificar master.page evento load, para activar mnu's segun los permisos de cada usuario (emparejar con los permisos del web.config)
//dentro de la session <system.web>
/*
        mnuVentasContado.Visible = Page.User.IsInRole("clientes");
        mnuVentasCredito.Visible = Page.User.IsInRole("clientes") || Page.User.IsInRole("administradores");
        mnuConfiguracionesSitio.Visible = Page.User.IsInRole("administradores");
*/

//TODO 07 Mostrar/Ocultar controles segun el rol del usuario, usarlo en page_load de la pagina VentasCredito
/*
        if (User.IsInRole("Administradores"))
            butCerrarVentaCreditoExcedido.Visible = true;
        else
            butCerrarVentaCreditoExcedido.Visible = false;
*/