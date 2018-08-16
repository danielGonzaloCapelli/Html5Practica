using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


namespace Html5
{
    public partial class ABMEspecialidad : System.Web.UI.Page
    {
        Entidades.Especialidad esp = new Entidades.Especialidad();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            esp.EspecialityDescription = "";
            esp.id = 0;
            try
            {
                if (txtDescripcionEspecialidad.Text.Length > 0)
                    esp.id = int.Parse(txtidEspecialidad.Text); { 
                    esp.EspecialityDescription = txtDescripcionEspecialidad.Text;
                    Negocio.Especialidad nEsp = new Negocio.Especialidad();
                    int resulta = nEsp.Agregar(esp);
                    if (resulta > 0)
                    {
                        Response.Write("<script>window.alert('Se envió el alta de manera correcta');</script>");
                        txtidEspecialidad.Text = "";
                        txtDescripcionEspecialidad.Text = "";
                    }
                    }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Default.aspx");
        }
    }
}