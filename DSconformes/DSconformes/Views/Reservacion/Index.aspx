<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<DSconformes.ws_zona.Zonas>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

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
			             
			            <asp:TextBox ID="TxtFecha" type="date" runat="server" class="form-control input-sm" required name="txtfecha"></asp:TextBox>
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
			                    <asp:TextBox ID="TxtTemas" runat="server" class="form-control input-sm" 
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
                         
                          <%:Html.DropDownListFor(m => m.id_zona, Model.nombre)%>

			                  <asp:DropDownList ID="ddlZona" runat="server" CssClass="dropdown" ></asp:DropDownList>
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
			                 <asp:TextBox ID="txtCantidad" type="number" runat="server"  style="width:100px"
                                    ></asp:TextBox>
			              </div>
			            </div>
                        <br /><br /><br /><br />
			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="BtnGrabar" runat="server" Text="Grabar" class="btn btn-primary" 
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
