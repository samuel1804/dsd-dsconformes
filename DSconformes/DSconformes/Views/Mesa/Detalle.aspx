<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle</h2><br />
    <label>ID:</label><asp:Label runat="server" ID="lblId"></asp:Label> <br /><br />
    <label>Descripcion:</label><asp:Label runat="server" ID="lblDescripcion"></asp:Label> <br /><br />
    <label>#Sillas:</label><asp:Label runat="server" ID="lblSillas"></asp:Label> <br /><br />
    <label>Descripcion:</label><asp:CheckBox runat="server" ID="chkHabilitado"></asp:CheckBox> <br /><br />
</asp:Content>
