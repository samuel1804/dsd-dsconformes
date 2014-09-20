<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mesero.aspx.cs" Inherits="DSconformes.Presentacion.Mesero" %>

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
                              required placeholder="Ingrese el Código"  ></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
			             <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">DNI</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:TextBox ID="TextBox1" runat="server" class="form-control input-sm"
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
			                    <asp:TextBox ID="TextBox2" runat="server" class="form-control input-sm"
                                required placeholder="Ingrese Nombres"  ></asp:TextBox>
			                </div>
			              </div>
			            </div>
                        <br /><br />
                        <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Mesa</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:TextBox ID="TextBox3" runat="server" class="form-control input-sm"
                              required placeholder="Ingrese el Código de la Mesa"  ></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
                        <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Sexo</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:DropDownList ID="TxtTemas" runat="server" class="form-control" 
                                    TextMode="MultiLine">
                                    <asp:ListItem Text="Hombre" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Mujer" Value="1"></asp:ListItem>
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
			                  <asp:TextBox ID="TextBox4" runat="server" class="form-control input-sm"
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
			              	   <asp:TextBox ID="TxtHora" type="number" runat="server" class="form-control input-sm" required min="12" max="23" name="txtHora" style="width: 55px; "></asp:TextBox>
			              	</div>
<div class="col-sm-4">
                            A
			              	   <asp:TextBox ID="TextBox5" type="number" runat="server" class="form-control input-sm" required min="16" max="23" name="txtHora" style="width: 55px; "></asp:TextBox>
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
