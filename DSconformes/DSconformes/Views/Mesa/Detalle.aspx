<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle</h2><br />
    <label>ID:</label><input type="text"  id="lblId" value="<%: ViewData["id_zona"] %>" /> <br /><br />
    <label>Descripcion:</label><input type="text" id="lblDescripcion"  value=" <%: ViewData["nombre"] %>" /><br /><br />
    <label>#Sillas:</label><input type="text"  id="lblSillas"  value=" <%: ViewData["capacidad"] %>" /> <br /><br />
    <label>Descripcion:</label><input type="checkbox" id="chkHabilitado" Checked="<%: ViewData["habilitado"] %>" /><br /><br />
</asp:Content>
