<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VentasCredito.aspx.cs" Inherits="VentasCredito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
    .style1
    {
        font-size: small;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>
        &nbsp;</h2>
<h2>
        Pagina Ventas Credito
         <span class="style1">(solo para usuarios con rol &quot;clientes&quot; o 
        &quot;ADMINISTRADORES&quot;)
        </span></h2>
<p>
        <asp:Button ID="butCerrarVenta" runat="server" Text="Cerrar Venta" />
        <asp:Button ID="butCerrarVentaCreditoExcedido" runat="server" 
            Text="Cerrar Venta Credito Excedido (solo para &quot;Administradores&quot;)" />
</p>
<p>
        Coloque contenido aquí.
    </p>
</asp:Content>

