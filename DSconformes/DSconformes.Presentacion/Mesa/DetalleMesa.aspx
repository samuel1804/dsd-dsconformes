<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" AutoEventWireup="true" CodeBehind="DetalleMesa.aspx.cs" Inherits="DSconformes.Presentacion.Mesas.DetalleMesa" %>




<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle</h2><br />
    <label>ID:</label><input type="text"  id="lblId"  /> <br /><br />
    <label>Descripcion:</label><input type="text" id="lblDescripcion"   /><br /><br />
    <label>#Sillas:</label><input type="text"  id="lblSillas"  /> <br /><br />
    <label>Descripcion:</label><input type="checkbox" id="chkHabilitado"  /><br /><br />
    <br /><br />
    <asp:Button ID="btnGrabar" runat="server" Text="Adicionar" class="btn btn-primary" />			              			             
    <asp:Button ID="btnSalir" runat="server" Text="Salir" class="btn btn-primary" />			              			         
</asp:Content>
