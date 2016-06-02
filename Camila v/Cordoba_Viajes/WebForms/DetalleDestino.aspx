<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DetalleDestino.aspx.cs" Inherits="WebForms_DetalleDestino" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" Runat="Server">
    <div class="panel panel-primary  col xs-8 col-xs-offset-2">
        <div class="panel-header">
            <h1>Destino <asp:Literal ID="litDescripcion" runat="server"></asp:Literal></h1>
                        
            <asp:Image ID="imgDestino" runat="server" CssClass="img-responsive img-circle" />
            <a href="Tienda.aspx" class="btn btn-primary">Seguir Decidiendo</a>
        </div>
    </div>

</asp:Content>

