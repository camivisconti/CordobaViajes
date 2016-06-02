<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DestinosMundoCliente.aspx.cs" Inherits="WebForms_DestinosMundoCliente" %>

<asp:Content ID="cntContenido1" ContentPlaceHolderID="cphHead" Runat="Server">
    <h1 title="DESTINOS SOÑADOS" class="text-info"></h1>
</asp:Content>
    

<asp:Content ID="cntContenido2" ContentPlaceHolderID="cphContenido" Runat="Server">
                    
    
    <div class="row">                   
         <asp:Repeater ID="rptDestinos" runat="server" OnItemCommand="rptDestinos_ItemCommand">
              <ItemTemplate>                           
                  <div class="col-sm-4 col-lg-4 col-md-4">                                
                      <div class="container"> 
                          <h4 class="text-danger"><%#Eval("nombre") %></h4>                       
                          <img  class="img-circle img-responsive" src="/boostrap/img/<%# Eval("Imagen") %>.jpg" alt="Imagen rota" width="304" height="236">
                          <div class="caption">
                          <p></p>                            
                          <asp:Button ID="btnSeleccionar" runat="server" Text="Este es el destino soñado!" CssClass="btn btn-primary" CommandArgument='<%#Eval("idDestino") %>' CommandName="Seleccionar" />
<%--                          <asp:Button ID="btnVerArticulo" runat="server" Text="Ver Artículo" CssClass="btn btn-warning" CommandArgument='<%#Eval("idarticulo") %>' CommandName="Ver" />--%>
                             <%-- <h4 class="pull-right"><%# Eval("precio","{0:c}") %></h4>--%>
                          </div>
                          <div class="ratings">
                               <p>
                                   <span class="glyphicon glyphicon-star"></span>
                                   <span class="glyphicon glyphicon-star"></span>
                                   <span class="glyphicon glyphicon-star"></span>
                                   <span class="glyphicon glyphicon-star"></span>
                                   <span class="glyphicon glyphicon-star"></span>
                               </p>
                            </div>
                            </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
</asp:Content>

