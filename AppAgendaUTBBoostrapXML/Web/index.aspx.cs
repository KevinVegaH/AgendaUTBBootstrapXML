using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppAgendaUTBBoostrapXML.Modelo;
using AppAgendaUTBBoostrapXML.Datos;

namespace AppAgendaUTBBoostrapXML.Web
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Personas p = new Personas(
                                       txtId.Text,
                                       txtNombres.Text,
                                       txtApellidos.Text,
                                       EmailP.Text,
                                       EmailW.Text,
                                       TelefonoP.Text,
                                       TelefonoW.Text
                                      );

            Crear data = new Crear();

            
            data.WriteXML(p);
           

           

        }
    }
}