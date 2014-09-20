using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSconformes;
namespace DSconformes.Presentacion
{
    public partial class Reservar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) {
               ws_zona.Zona zona = new ws_zona.Zona();
               ddlZona.DataSource= zona.ListarZonas();
               ddlZona.DataTextField = "id_zona";
               ddlZona.DataValueField = "nombre";
               ddlZona.DataBind();
            }
        }
    }
}