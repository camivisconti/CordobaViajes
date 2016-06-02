<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CordobaViajes.aspx.cs" Inherits="CordobaViajes" %>

<asp:Content ID="cntHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cntContenido" ContentPlaceHolderID="cphContenido" Runat="Server">


    <div class="container">

        <hr>
             <h1 class="tagline" designer:mapid="4a9" style="color:black">Armá el viaje de tu vida !!! </h1>
        <hr>
        

        <asp:Panel ID="panelGrande"  runat="server">
            <header class="business-header">
                
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                     <img class="img-center img-responsive" src="/boostrap/img/poneresta.jpg" alt="Encabezado"  style ="width:1019px; height:394px" >
               
                     </div>
            </div>
        </div>
    </header>
           
        <div class="row">
         
            <div class="col-sm-4">
                <img class="img-circle img-responsive img-center" src="/boostrap/img/portada.jpg" alt="Destinos">
                <h2 id="h2">Destinos del mundo</h2>
                <p>Aquí encontrarás los mejores lugares del mundo para conocer.</p>
            <asp:Button ID="btnSeleccionarDestino" cssClass="btn btn-info" runat="server" Text="Elegí tu destino" OnClick="btnSeleccionarDestino_Click" />
            </div>
            <div class="col-sm-4">
                <img class="img-circle img-responsive img-center" src="/boostrap/img/cabañas.jpg" alt="Hospedajes">
                <h2>Hospedajes</h2>
                <p>Busca la mejor cabaña para hospedarte durante tu viaje soñado.</p>
           <asp:Button ID="btnSeleccionarHospedaje" CssClass="btn btn-success" runat="server" Text="Elegí tu Hospedaje" />
                 </div>
            <div class="col-sm-4">
                <img class="img-circle img-responsive img-center" src="/boostrap/img/buceo.jpg" alt="Excursiones">
                <h2>Excursiones</h2>
                <p>Elije las excursiones mas divertidas para realizar durante el viaje.</p>
                <asp:Button ID="btnSeleccionarExcursiones" CssClass="btn btn-warning" runat="server" Text="Elegí tus Excursiones" />
                </div>
        </div>
        <!-- /.row -->
        </asp:Panel>

        </p>

        <asp:Panel ID="PanelDestinos" runat="server">
            <asp:Label ID="lblDestinos" runat="server" Text="Destinos del mundo"></asp:Label>
            <br />
            <asp:Label ID="lblAccion" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_buscar_loc" runat="server" Text="Nombre de Localidad:"></asp:Label>

            <asp:TextBox ID="txtBuscarLocalidad" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btn_buscar" runat="server" OnClick="btn_buscar_Click" Text="Buscar" />
            <br />
            <br />
            <br />

            <asp:GridView ID="gvDestinos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">

                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="nombre" HeaderText="Localidad" SortExpression="nombreLocalidad" />
                    <asp:BoundField DataField="pais" HeaderText="Pais" SortExpression="nombrePais" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />

            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnAgregarDestino" runat="server" Text="Agregar" Height="26px" OnClick="btnAgregarDestino_Click" Width="73px" />
            <asp:Button ID="btnConsultarDestino" runat="server" Text="Consultar" Width="76px" />
            <asp:Button ID="btnEliminarDestino" runat="server" Text="Eliminar" Width="67px" />
            <asp:Button ID="btnEditarDestino" runat="server" Text="Editar" Width="65px" />
            <asp:Button ID="btnDestinoVolver" runat="server" Text="Volver" OnClick="btnDestinoVolver_Click" />
            <br />
        </asp:Panel>
        <asp:Panel ID="panelRegistro" runat="server">
            &nbsp;&nbsp;
            <br />
            <asp:Label ID="lbl_nombreDestino" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_nombreDestino" runat="server" Width="123px"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_Pais" runat="server" Text="País:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlPais" runat="server" Height="16px" Width="122px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btn_grabar" runat="server" OnClick="Button1_Click" Text="Grabar" />
            <br />
        </asp:Panel>
        

        <!-- Footer -->
        
        <hr>


        <footer>
            <div class="row">
                <div class="col-lg-12">
                    <p>Copyright &copy; Your Website 2014         </div>
            </div>
            <!-- /.row -->
        </footer>

    </div>

</asp:Content>

