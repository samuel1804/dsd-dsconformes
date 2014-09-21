<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" AutoEventWireup="true" CodeBehind="Reservar.aspx.cs" Inherits="DSconformes.Presentacion.Reservas.Reservar" %>




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
        <h3><strong >Registro de Reservación</strong></h3> 
      	        
        </div>
        <br>
        <div class="row">
          <div class="col-sm-3"></div>
           <div class="col-sm-6"> 
        	 <div class="well">
        		</div>
         		 <input type="hidden" name="hidDirectivos">	  
         		  <div id="hidepage" style="position: absolute;left:320px;top:290px;width: 150;height: 20">
                        <%-- <img  src="<%=request.getContextPath()%>/css/progress_bar.gif" >--%>
					</div>          		 				
		         	
           
          		 
          		 
          		 <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Fecha</label>
			              </div>
			              <div class="col-sm-4">
			             
			            <asp:TextBox ID="TxtFecha" type="date" runat="server" class="form-control input-sm" name="txtfecha"></asp:TextBox>
			              </div>
			              <div class="col-sm-1">
			                <label class="form-label">Hora</label>
			              </div>
			              <div class="col-sm-5">
			              	<div class="col-sm-4">
			              	   <asp:TextBox ID="TxtHora" type="number" runat="server" class="form-control input-sm" required min="6" max="23" name="txtHora" style="width: 55px; "></asp:TextBox>
			              	</div>
			              	<div class="col-sm-8">
			              		:00 Hrs
			              	</div>
			             
			              </div>
			     </div>
			             <br /><br />
			            <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Nombres</label>
			              </div>
			              
			                <div class="col-sm-10">
			                    <asp:TextBox ID="txtNombre" runat="server" class="form-control input-sm" 
                                    required placeholder="Ingrese su Nombre"></asp:TextBox>
			                </div>
			             </div>
                         <br />
                         <div class="form-group">
                          <div class="col-sm-2">
			                <label class="form-label">DNI</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:TextBox ID="txtDNI" runat="server" class="form-control input-sm" required placeholder="Ingrese DNI" ></asp:TextBox>
			              </div>
			            </div>
			              <br/>
                          <div class="form-group">
                          <div class="col-sm-2">
			                <label class="form-label">Zona</label>
			              </div>
			              <div class="col-sm-10">
                         
                         
			                  <asp:DropDownList ID="ddlZona" runat="server" CssClass="dropdown" 
                                  AutoPostBack="True" onselectedindexchanged="ddlZona_SelectedIndexChanged" ></asp:DropDownList>
			              </div>
			            </div>
                        <br />
                        <div class="form-group">
                          <div class="col-sm-2">
			                <label class="form-label">Mesa</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:DropDownList ID="ddlMesa" runat="server" CssClass="dropdown" ></asp:DropDownList>
			              </div>
			            </div>
			            <br />
                        <div class="form-group">
                          <div class="col-sm-2">
			                <label class="form-label">Nro. Personas</label>
			              </div>
			              <div class="col-sm-10">
			                 <asp:TextBox ID="txtCantidad" type="number" runat="server"  class="form-control input-sm" required min="1" max="20"  style="width:100px"
                                    ></asp:TextBox>
			              </div>
			            </div>
                        <br /><br />
                     <div style="text-align:center"><asp:Label ID="lblMensaje" runat="server" 
                             Font-Bold="True" ForeColor="#00CC00"></asp:Label></div>
                     <br /><br />
			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="BtnGrabar" runat="server" Text="Grabar" class="btn btn-primary" onclick="BtnGrabar_Click" 
                                       />			              			             
					            </div>
					          </div>	
				          </c:if>	
			          </div>			         
			          	          		 			          		           		        
     
         	</div>
         </div>
        
         
           </div>
          
           
       

         </ContentTemplate>

        </asp:UpdatePanel>

</asp:Content>

