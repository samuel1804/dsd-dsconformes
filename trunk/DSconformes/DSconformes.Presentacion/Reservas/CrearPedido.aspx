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
                            <asp:UpdatePanel ID="upPedidos" runat="server">
                            <ContentTemplate>
                            <asp:GridView ID="gvPedidos" runat="server" AutoGenerateColumns="False" 
                                    Width="100%">
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
                                            CommandName="Edit" ImageUrl="~/image/edit.png" /></ItemTemplate></asp:TemplateField>
                                </Columns>
                                </asp:GridView>
			                </ContentTemplate></asp:UpdatePanel>
                            </div>
			             </div>
                         <br />
                         <br />
                        
                        <asp:Button id="btnShowPedido" runat="server"/>
               <cc1:ModalPopupExtender ID="mpePedido" runat="server" 
                         CancelControlID="btnCerrarPedido" PopupControlID="pnlPedido" 
                         TargetControlID="btnShowPedido">
               </cc1:ModalPopupExtender>
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
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:GridView ID="gvPedidoDetalle" runat="server"></asp:GridView></td>
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

