using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CordobaViajes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PanelDestinos.Visible = false;
        panelGrande.Visible = true;
        panelRegistro.Visible = false;
       

        if (Page.IsPostBack)
        {

            ddlPais.DataTextField = "nombre";
            ddlPais.DataValueField = "id_pais";
            ddlPais.DataSource = GestorDestino.ObtenerTodos();
            ddlPais.DataBind();
            ddlPais.Items.Insert(0, new ListItem("Elija un país", "0"));


            ViewState["GvDatosOrden"] = "nombre"; // por lo q ordeno la grilla
            gvDestinos.AllowPaging = true;
            gvDestinos.AllowSorting = true;
            gvDestinos.AutoGenerateColumns = false;
            gvDestinos.PageSize = 7;
            CargarGrilla();
        }
    }
    private void CargarGrilla()
    {
        string orden = ViewState["GvDatosOrden"].ToString();
        gvDestinos.DataSource = GestorDestino.BuscarPorNombre(txtBuscarLocalidad.Text, orden);
        gvDestinos.DataBind();
    }



    protected void btnSeleccionarDestino_Click(object sender, EventArgs e)
    {
        //panelGrande.Visible = false;
        //PanelDestinos.Visible = true;
        //GestorDestino gd = new GestorDestino();
        //cargarGrillaDestino();

        Response.Redirect("DestinosMundoCliente.aspx");
    }

    private void cargarGrillaDestino()
    {
        //string orden = ViewState["GvDatosOrden"].ToString();
        gvDestinos.DataSource = GestorDestino.buscarTodos();
        gvDestinos.DataBind();
    }

    protected void btnDestinoVolver_Click(object sender, EventArgs e)
    {
        PanelDestinos.Visible = false;
        panelGrande.Visible = true;
        panelRegistro.Visible = false;
       

    }
    protected void gvDestinos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnAgregarDestino_Click(object sender, EventArgs e)
    {
        panelGrande.Visible = false;
        PanelDestinos.Visible = false;
        panelRegistro.Visible = true;
        lblAccion.Text = "Agregando...";
        //txt_idDestino.Text = "";
        txt_nombreDestino.Text = "";
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        panelGrande.Visible = true;
        panelRegistro.Visible = false;
        lblAccion.Text = "Grabando...";

        Destino destino = new Destino();

        destino.nombre = txt_nombreDestino.Text;
        destino.idPais = Convert.ToInt32(ddlPais.SelectedValue);


        GestorDestino.Grabar(destino);

    }
    protected void btn_buscar_Click(object sender, EventArgs e)
    {
        CargarGrilla();
    }
}