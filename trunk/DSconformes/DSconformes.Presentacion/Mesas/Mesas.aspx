<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" AutoEventWireup="true" CodeBehind="Mesas.aspx.cs" Inherits="DSconformes.Presentacion.Mesas.Mesas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <asp:UpdatePanel ID="uptabla" runat ="server"><ContentTemplate>

          <div class="container">
      
        <div class="text-center">
        <h3><strong >Mesas</strong></h3> 
      	        
        </div>
        
              <label>Zona:</label>   <br>

        <div class="row">
          <div class="col-sm-3"></div>
           <div class="col-sm-6"> 
        	 <div class="well">
        		</div>
         		 <input type="hidden" name="hidDirectivos">	  
         		  <div id="hidepage" style="position: absolute;left:320px;top:290px;width: 150;height: 20">
                        <%-- <img  src="<%=request.getContextPath()%>/css/progress_bar.gif" >--%>
					</div>          		 				
		         	
                    <div>
                    <table style="width: 100%;" border="1">
        <tr>
            <td>
               <label>Código</label>
            </td>
            <td>
                 <label>Mesa</label>
            </td>
            <td>
                <label>Capacidad</label>
            </td>
              <td>
                <label>Seleccione</label>
            </td>
        </tr>
        <tr>
            <td>
                1
            </td>
            <td>
               M1
            </td>
            <td>
               4
            </td>
            <td>
                <label></label>
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl="~/Mesas/DetalleMesa.aspx">Seleccione</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                2
            </td>
            <td>
               M2
            </td>
            <td>
               25
            </td>
            <td>
                <label></label>
                <asp:HyperLink ID="HyperLink2" runat="server" 
                    NavigateUrl="~/Mesas/DetalleMesa.aspx">Seleccione</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
               3
            </td>
            <td>
               M3
            </td>
            <td>
               150
            </td>
            <td>
                <label></label> <asp:HyperLink ID="HyperLink3" runat="server" 
                    NavigateUrl="~/Mesas/DetalleMesa.aspx">Seleccione</asp:HyperLink>
            </td>
        </tr>
    </table>
                    </div>
          		 
          		 
          		 
			         
                        <br /><br /><br />

			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="btnGrabar" runat="server" Text="Adicionar" class="btn btn-primary" />			              			             
                                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" class="btn btn-primary" />			              			             
                                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-primary" />			              			             
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
