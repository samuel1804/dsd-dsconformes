<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" AutoEventWireup="true" Inherits="DSconformes.Presentacion.Mesero.Mesero" CodeBehind="Mesero.aspx.cs"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

      <asp:UpdatePanel ID="uptabla" runat ="server"><ContentTemplate>

          <div class="container">
      
        <div class="text-center">
        <h3><strong >Registrar Meseros</strong></h3> 
      	        
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
			                <label class="form-label">Codigo</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:TextBox ID="id_mesero" runat="server" class="form-control input-sm"
                              ReadOnly="True"  ></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
			             <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">DNI</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:TextBox ID="TextDNI" runat="server" class="form-control input-sm"
                              required placeholder="Ingrese el DNI"  ></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
                         <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Nombres</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:TextBox ID="TextNombres" runat="server" class="form-control input-sm"
                                required placeholder="Ingrese Nombres"  ></asp:TextBox>
			                </div>
			              </div>
			            </div>
                        <br /><br />
                        <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Zona</label>
			              </div>
			              <div>
                          <div class="col-sm-10">
			                  <asp:UpdatePanel ID="upZona" runat="server">
                              <ContentTemplate>
                              <asp:DropDownList ID="ddlZona" runat="server" class="form-control"
                                    TextMode="MultiLine" AutoPostBack="True" 
                                  onselectedindexchanged="ddlZona_SelectedIndexChanged">
                                   
                                    </asp:DropDownList>
                              </ContentTemplate>
                              </asp:UpdatePanel>
			                </div>
			             </div>
			            </div>
                        <br /><br />
                        <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Mesa</label>
			              </div>
			              <div>
                          <div class="col-sm-10">
			                  <asp:UpdatePanel ID="upMesa" runat="server">
                              <ContentTemplate>
                              <asp:DropDownList ID="ddlMesa" runat="server" class="form-control"
                                    TextMode="MultiLine">
                                   
                                    </asp:DropDownList>
                              </ContentTemplate>
                              </asp:UpdatePanel>
			                </div>
			             </div>
			            </div>
			            <br /><br />
                        <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Sexo</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:DropDownList ID="TxtSexo" runat="server" class="form-control" 
                                    TextMode="MultiLine">
                                    <asp:ListItem Text="Hombre" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Mujer" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
			                </div>
			              </div>
			            </div>
                        <br /><br />
                         <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Edad</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:TextBox ID="TxtEdad" runat="server" class="form-control input-sm"
                              required placeholder="Ingrese la edad"  ></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
                        <div class="col-sm-2">
			                <label class="form-label">Horario</label>
			              </div>
			              <div class="col-sm-5">
			              	<div class="col-sm-4">
                            DE
			              	   <asp:TextBox ID="TxtEntrada" type="number" runat="server" class="form-control input-sm" required min="12" max="23" name="txtHora" style="width: 55px; "></asp:TextBox>
			              	</div>
<div class="col-sm-4">
                            A
			              	   <asp:TextBox ID="TxtSalida" type="number" runat="server" class="form-control input-sm" required min="16" max="23" name="txtHora" style="width: 55px; "></asp:TextBox>
			              	</div>
			             
			              </div>
			     </div>
			             <br /><br />

                         <div style="text-align:center"><asp:Label ID="lblMensaje" runat="server" 
                             Font-Bold="True" ForeColor="#00CC00"></asp:Label></div>
                             <div style="text-align:center"><asp:Label ID="lblMensajeError" runat="server" 
                             Font-Bold="True" ForeColor=Red></asp:Label></div>
                             <br />
                        <br />


			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="BtnGrabar" runat="server" Text="Guardar"
                                        class="btn btn-primary" onclick="BtnGrabar_Click"
                                        />
                                        <asp:Button ID="btnLimpiar" runat="server" class="btn btn-primary" 
                                        Text="Limpiar" onclick="btnLimpiar_Click" />			              			             
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
