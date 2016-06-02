<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="IniciarSesion.aspx.cs" Inherits="WebForms_IniciarSesion" %>

<asp:Content ID="cntContenido1" ContentPlaceHolderID="cphHead" Runat="Server">
        <script type="text/javascript">
        function validarMotivo(src, args) {
            if (args.Value === "0") {
                args.IsValid = false;
            }
            else {
                args.IsValid = true;
            }
        }

        </script>
</asp:Content>
<asp:Content ID="cntContenido2" ContentPlaceHolderID="cphContenido" Runat="Server">

    <div class="container">
       <div class="row">
           <div class="col-sm-6 col-sm-offset-3">
               <div class="panel panel-primary">
                   <div class="panel-heading panel-info">
                       <h3 class="panel-tittle">Inicar Sesión</h3>
                   </div>
                   <div class="panel panel-body panel-info">

                       <div class="form-group">
                           <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate1" LoginButtonStyle-CssClass="btn btn-info">
                               
                           </asp:Login>   
                           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
                           <asp:Button ID="btnLogOut" runat="server" Text="Cerrar Sesión" cssClass="btn btn-info" OnClick="btnLogOut_Click" Width="165px" />                                                   
                       </div>
                       <asp:ValidationSummary ID="val_summary" runat="server" HeaderText="Han ocurrido los siguientes errores" />
                   </div>
                    <%--<asp:Button ID="btn_InciarSesion" runat="server" Text="Inciar Sesión" CssClass="btn btn-info btn-lg" OnClick="btn_InciarSesion_Click" />
                    <asp:Button ID="btn_RegistrarNuevo" runat="server" Text="Registrarme, soy nuevo" CssClass="btn btn-info btn-lg" />--%>
               </div>
               <asp:Label ID="lbl_resultado" runat="server" Text="" BorderStyle="Double" BorderColor="#6666FF" Font-Bold="True" Font-Size="Large"></asp:Label>
           </div>
       </div>
   </div>
   
    <asp:Panel ID="panel_continuar" runat="server">
        <a href="CordobaViajes.aspx" class="btn btn-warning btn-block">Continuar</a>
    </asp:Panel>
    
</asp:Content>

