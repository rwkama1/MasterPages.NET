using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using EntidadesCompartidas;
using Logica;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            Session["EMP"] = null;
    }
    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        try
        {
            int ci = Convert.ToInt32(txtCI.Text);
            string pass = txtPass.Text;
            Empleado emp = LogicaEmpleado.Logueo(ci, pass);
            Session["EMP"] = emp;
            if (emp is Jornalero)
                Response.Redirect("AgregarJornalero.aspx");
            if (emp is Asalariado)
                Response.Redirect("AgregarAsalariado.aspx");
            if (emp == null)
                lblInfo.Text = "Usuario y/o contraseña incorrectas.";
        }
        catch (Exception ex)
        {
            lblInfo.Text = ex.Message;
        }
    }
}
