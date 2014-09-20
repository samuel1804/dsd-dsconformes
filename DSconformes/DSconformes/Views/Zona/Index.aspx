<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Mantenimiento de zonas
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Listado de Zonas
    </h2>


    <div>
          
    </div>
    <table style="width: 100%;" border="1">
        <tr>
            <td>
               <label>Código</label>
            </td>
            <td>
                 <label>Nombre</label>
            </td>
            <td>
                <label>Máximo de Personas</label>
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
               Eventos
            </td>
            <td>
               50
            </td>
            <td>
                <label><%: Html.ActionLink("Seleccione", "Index", "Mesa", new { codigoZona = 1, nombre = "Eventos", capacidad = 50  }, null)%></label>
            </td>
        </tr>
        <tr>
            <td>
                2
            </td>
            <td>
               Terraza
            </td>
            <td>
               25
            </td>
            <td>
                <label><%: Html.ActionLink("Seleccione", "Index", "Mesa", new { codigoZona = 2, nombre = "Terraza", capacidad = 25 }, null)%></label>
            </td>
        </tr>
        <tr>
            <td>
               3
            </td>
            <td>
               Publico
            </td>
            <td>
               150
            </td>
            <td>
                <label><%: Html.ActionLink("Seleccione", "Index", "Mesa", new { codigoZona = 1, nombre = "Publico", capacidad = 150 }, null)%></label>
            </td>
        </tr>
    </table>

</asp:Content>
