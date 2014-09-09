<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="frmCategoria" runat="server">
    <div class="tablaCategoria">
    <h2>Categorias</h2>
    <div class="tablarow">
    <div class="tablaizquierda">Codigo:</div><div class="tabladerecha"><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></div>
    </div>
    <div class="tablarow">
    <div class="tablaizquierda">Descripcion:</div><div class="tabladerecha"><asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></div>
    </div>
    <div class="tablaseparator"></div>
    <div class="tablarow">
   <div class="tablafinal"><asp:Button ID="Button1" Text="Guardar" runat="server"/> <asp:Button ID="Button2" Text="Limpiar" runat="server"/></div> 
    </div>
    </div>
    </form>
</asp:Content>
