using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using EntidadesCompartidas;

public partial class MasterPageJornaleros : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Session["EMP"] is Jornalero))
            Response.Redirect("Default.aspx");
        lblNombreUser.Text = "Bienvenid@: " + ((Jornalero)Session["EMP"]).Nombre;
    }
    protected void btnCerrarSession_Click(object sender, EventArgs e)
    {
        Session["EMP"] = null;
        Response.Redirect("Default.aspx");
    }
}
