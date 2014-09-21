<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" Inherits="DSconformes.Presentacion.Platos.Platos" CodeBehind="Platos.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

      <asp:UpdatePanel ID="uptabla" runat ="server"><ContentTemplate>

          <div class="container">
      
        <div class="text-center">
        <h3><strong >Registrar Platos</strong></h3> 
      	        
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
			                  <asp:TextBox ID="txtCodigo" runat="server" class="form-control input-sm"  ></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
			            <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Categoria</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:DropDownList ID="TxtTemas" runat="server" class="form-control" 
                                    TextMode="MultiLine">
                                    <asp:ListItem Text="Ensaladas" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Carnes" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Vinos" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Postres" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Gaseosas" Value="1"></asp:ListItem>
                                    </asp:DropDownList>
			                </div>
			              </div>
			            </div>
                        <br /><br />
                         <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Nombre</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:TextBox ID="TextBox1" runat="server" class="form-control" 
                                    required placeholder="Ingrese Nombre del Plato" ></asp:TextBox>
			                </div>
			              </div>
			            </div>
                        <br /><br />
                         <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Precio</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:TextBox ID="TextBox2" runat="server" class="form-control" 
                                    required placeholder="0,00" ></asp:TextBox>
			                </div>
			              </div>
			            </div>
                        <br /><br />

			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="BtnGrabar" runat="server" Text="Guardar" class="btn btn-primary" 
                                        />			              			             
                                    <asp:Button ID="btnEliminar" runat="server" class="btn btn-primary" 
                                        Text="Eliminar" />			              			             
                                    <asp:Button ID="btnActualizar" runat="server" class="btn btn-primary" 
                                        Text="Actualizar" />			              			             
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
