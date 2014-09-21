<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" CodeBehind="Zonas.aspx.cs" Inherits="DSconformes.Presentacion.Zonas.Zonas" %>

<asp:Content ID="Content3" ContentPlaceHolderID="TitleContent" runat="server">
	Mantenimiento de zonas
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

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
               <asp:HyperLink ID="hlMesa" runat="server" NavigateUrl="~/Mesas/Mesas.aspx">Seleccionar</asp:HyperLink>
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
               
               <asp:HyperLink ID="hlMesa0" runat="server" NavigateUrl="~/Mesas/Mesas.aspx">Seleccionar</asp:HyperLink>
               
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
               <asp:HyperLink ID="hlMesa1" runat="server" NavigateUrl="~/Mesas/Mesas.aspx">Seleccionar</asp:HyperLink>
               </td>
        </tr>
    </table>

</asp:Content>
