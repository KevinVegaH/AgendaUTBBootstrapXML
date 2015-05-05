using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAgendaUTBBoostrapXML.Modelo;
using System.Xml;
using System.Web.Hosting;


namespace AppAgendaUTBBoostrapXML.Datos
{
    public class Crear
    {

        public void WriteXML(Personas p)
        {
            string ruta = HttpContext.Current.Server.MapPath("/Datos/Agenda.xml");
            XmlTextWriter xmlwriter = new XmlTextWriter(ruta, System.Text.Encoding.UTF8);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.WriteStartDocument();
            xmlwriter.WriteStartElement("People");
            xmlwriter.WriteStartElement("Personas");
            xmlwriter.WriteElementString("ID", p.Id);
            xmlwriter.WriteElementString("Nombres", p.Nombres);
            xmlwriter.WriteElementString("Apellido", p.Apellidos);
            xmlwriter.WriteElementString("EmailP", p.EmailP);
            xmlwriter.WriteElementString("EmailW", p.EmailW);
            xmlwriter.WriteElementString("TelefonoP", p.TelefonoP);
            xmlwriter.WriteElementString("TelefonoW", p.TelefonoW);
            xmlwriter.WriteEndElement();
            xmlwriter.WriteEndElement();
            //xmlwriter.WriteEndDocument();
            xmlwriter.Flush();
            xmlwriter.Close();
        }


    }
}