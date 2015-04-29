using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAgendaUTBBoostrapXML.Modelo
{
    public class Personas
    {
        #region propiedades

        private int id;
        private string email;
        private int telefono;

        

        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        #endregion

        #region costructor
        public Personas () {

            this.id = 123;
            this.email = "xxxxx@hotmail.com";
            this.telefono = 1234;

        
        }
        public Personas(int id,string email ,int telefono) {

            this.id = id;
            this.email = email;
            this.telefono = telefono;

        }
#endregion

        #region "Methods Override"
        public override string ToString()
        {
            return "\n________________________________________________ \n" +
                "\n ID = " + id + "\n" +
                "\n email = " + email + "\n" +
                "\n Telefono = " + telefono + "\n" ;

        }
        public override bool Equals(object obj)
        {

            Personas c = (Personas)obj;
            bool result = false;

            if ((this.id == c.id) && (this.email == c.email) &&  (this.telefono == c.telefono))
            {
                result = true;
            }

            return result;
        }


        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    #endregion
   
    
    
    
    }


}