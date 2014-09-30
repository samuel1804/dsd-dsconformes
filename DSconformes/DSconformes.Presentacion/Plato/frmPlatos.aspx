<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" Inherits="DSconformes.Presentacion.Plato.frmPlatos" CodeBehind="frmPlatos.aspx.cs" %>

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
			                  <asp:TextBox ID="txtCodigo" runat="server" class="form-control input-sm" 
                                  ReadOnly="True"  ></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
			            <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Categoria</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:DropDownList ID="ddlCategoria" runat="server" class="form-control" 
                                    TextMode="MultiLine">
                                   
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
			                    <asp:TextBox ID="txtnombre" runat="server" class="form-control" 
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
			                    <asp:TextBox ID="txtPrecio" runat="server" class="form-control" 
                                    required placeholder="0,00" ></asp:TextBox>
			                </div>
			              </div>
			            </div>
                        <br /><br />
                         <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Descripcion</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:TextBox ID="txtDescripcion" runat="server" class="form-control" 
                                    required placeholder="Ingrese Descripcion del Plato" ></asp:TextBox>
			                </div>
			              </div>
			            </div>
                        <br /><br />
                         <div style="text-align:center"><asp:Label ID="lblMensaje" runat="server" 
                             Font-Bold="True" ForeColor="#00CC00"></asp:Label></div>
                             <br />
                        <br />

                        

			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="BtnGrabar" runat="server" Text="Guardar" 
                                        class="btn btn-primary" onclick="BtnGrabar_Click" 
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
