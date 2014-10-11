<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" AutoEventWireup="true" CodeBehind="CrearPedido.aspx.cs" Inherits="DSconformes.Presentacion.Reservas.CrearPedido" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>




<asp:Content ID="Content3" ContentPlaceHolderID="TitleContent" runat="server">
Reservas
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Contentheader" runat="server">
    <script type="text/javascript">
    $("txtfecha.DateFrom").datepicker({
    minDate: 0,
});
        </script>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

   
      
    <asp:UpdatePanel ID="uptabla" runat ="server"><ContentTemplate>

          <div class="container">
      
        <div class="text-center">
        <h3><strong >Crear Pedido</strong></h3> 
      	        
        </div>
        <br>
        <div class="row">
          <div class="col-sm-1"></div>
           <div class="col-sm-10"> 
        	 <div class="well">
        		</div>
         		 <input type="hidden" name="hidDirectivos">	  
         		  <div id="hidepage" style="position: absolute;left:320px;top:290px;width: 150;height: 20">
                        <%-- <img  src="<%=request.getContextPath()%>/css/progress_bar.gif" >--%>
					</div>          		 				
		         	
           
          		 
          		 
          		 <div class="form-group">
			              <div class="col-sm-1">
			                <label class="form-label">Nombre</label>
			              </div>
			              <div class="col-sm-3">
			             
			            <asp:TextBox ID="txtBuscarNombre" runat="server"  class="form-control input-sm" 
                                    placeholder="Buscar por Nombre"></asp:TextBox>
			              </div>
			              <div class="col-sm-1">
			                <label class="form-label">DNI</label>
			              </div>
			              <div class="col-sm-3">
			              	
			              	   <asp:TextBox ID="txtBuscarDNI" runat="server"  class="form-control input-sm" 
                                    placeholder="Buscar por DNI"  ></asp:TextBox>
			              	
			              </div>
                          <div class="col-sm-3">
                           
					                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" onclick="btnBuscar_Click"
                                       />			              			             
					            
                          </div>
			     </div>
			             <br /><br />
                         <br />
			            <div>
			              
			                <div>
                            <asp:UpdatePanel ID="upPedidos" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                            <asp:GridView ID="gvPedidos" runat="server" AutoGenerateColumns="False" 
                                    Width="100%" onrowupdating="gvPedidos_RowUpdating">
                                <Columns>
                                    <asp:BoundField DataField="id_reserva" HeaderText="Codigo" HeaderStyle-HorizontalAlign="Center" >
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="nombre" HeaderText="Nombres" />
                                    <asp:BoundField DataField="dni" HeaderText="DNI" />
                                    <asp:BoundField DataField="id_mesa" HeaderText="Mesa" />
                                    <asp:TemplateField HeaderText="Ped."><ItemTemplate>
                                        <asp:ImageButton runat="server" 
                                            CommandName="Update" ImageUrl="~/image/edit.png" 
                                            CausesValidation="False" /></ItemTemplate></asp:TemplateField>
                                </Columns>
                                </asp:GridView>
			                </ContentTemplate></asp:UpdatePanel>
                            </div>
			             </div>
                         <br />
                         <br />
                        <asp:UpdatePanel ID="upPedidoShow" runat="server" UpdateMode="Always">
                        <ContentTemplate>
                        <asp:Button id="btnShowPedido" runat="server"/>
               <cc1:ModalPopupExtender ID="mpePedido" runat="server" 
                         CancelControlID="btnCerrarPedido" PopupControlID="pnlPedido" 
                         TargetControlID="btnShowPedido" Drag="True" DropShadow="True">
               </cc1:ModalPopupExtender>
              </ContentTemplate>
               </asp:UpdatePanel>


                        <asp:Panel ID="pnlPedido" runat="server" Width="700px" BackColor="White">
                        <table style="background-color:Gray">
                        <tr>
                        <td style="width:99%; text-align: left;"><strong>Detalle del Pedido</strong> </td>
                        <td><asp:Button id="btnCerrarPedido" runat="server" Text="X"/></td>
                        </tr>
                        </table>
                            <table class="nav-justified">
                                <tr>
                                    <td style="width:2%">
                                        &nbsp;</td>
                                    <td  style="width:15%">
                                        &nbsp;</td>
                                    <td  style="width:2%">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td  style="width:30%">
                                        &nbsp;</td>
                                    <td  style="width:2%">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td >
                                        Categorias</td>
                                    <td>
                                        :</td>
                                    <td>
                                    <asp:UpdatePanel ID="upCategoria" runat="server">
                                    <ContentTemplate>
                                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="80%" AutoPostBack="True" 
                                            onselectedindexchanged="ddlCategoria_SelectedIndexChanged"></asp:DropDownList>
                                    </ContentTemplate>
                                    </asp:UpdatePanel>
                                        </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        Platos</td>
                                    <td>
                                        :</td>
                                    <td>
                                        <asp:UpdatePanel ID="upPlato" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="ddlPlato" runat="server" AutoPostBack="True" 
                                                    Width="80%" onselectedindexchanged="ddlPlato_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td>
                                       <asp:UpdatePanel id="upAgregar" runat="server">
                                       <ContentTemplate>
                                        <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" 
                                            onclick="btnAgregar_Click" Text="Agregar" />
                                       </ContentTemplate>
                                       </asp:UpdatePanel>
                                        </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        Costo</td>
                                    <td>
                                        :</td>
                                    <td>
                                        <asp:UpdatePanel ID="upCosto" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        Cantidad</td>
                                    <td>
                                        :</td>
                                    <td>
                                        <asp:UpdatePanel ID="upCantidad" runat="server">
                                            <ContentTemplate>
                                                <asp:HiddenField ID="hfIdReserva" runat="server" />
                                                <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:GridView ID="gvPedidoDetalle" runat="server" AutoGenerateColumns="False">
                                            <Columns>
                                                <asp:BoundField DataField="nombre" HeaderText="Plato" />
                                                <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                                <asp:BoundField DataField="costo" HeaderText="Costo" />
                                                <asp:BoundField DataField="subtotal" HeaderText="SubTotal" />
                                            </Columns>
                                        </asp:GridView></td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                       

                        </asp:Panel>

                        <br /><br />
                     <div style="text-align:center"><asp:Label ID="lblMensaje" runat="server" 
                             Font-Bold="True" ForeColor="#00CC00"></asp:Label></div>
                     <br /><br />
			          			          	          		 			          		           		        
     
         	</div>
         </div>
        
         
           </div>
          
           
       

         </ContentTemplate>

        </asp:UpdatePanel>

</asp:Content>

