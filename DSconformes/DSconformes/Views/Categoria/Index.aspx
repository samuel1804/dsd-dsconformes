<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="uptabla" runat ="server"><ContentTemplate>

          <div class="container">
      
        <div class="text-center">
        <h3><strong >Registrar Categoría</strong></h3> 
      	        
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
			                  <asp:TextBox ID="txtCodigo" runat="server" class="form-control input-sm" required placeholder="Tema" TextMode="MultiLine"></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
			            <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Categoria</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:TextBox ID="TxtTemas" runat="server" class="form-control input-sm" 
                                    required placeholder="Ingrese Nombre de Categoria" Height="88px" TextMode="MultiLine"></asp:TextBox>
			                </div>
			              </div>
			            </div>
			             
			           
			
			           <br>
                        <br /><br />
			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="BtnGrabar" runat="server" Text="Guardar" class="btn btn-primary" 
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
