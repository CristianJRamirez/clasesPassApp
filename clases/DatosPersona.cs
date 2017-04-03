using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class DatosPersona
    {
        public string ID { get; set; }
        public string userProgram { get; set; }
        public string passProgram { get; set; }
        public List<Page> pages;


        public DatosPersona()
        {
            pages = new List<Page>();
        }

        /// <summary> Inicializacion de la Persona con usuario y contraseña </summary>
        /// <param name="usr">codigo de inicio de sesion </param>
        /// <param name="pss">password de inicio de sesion </param>
        public DatosPersona(string usr, string pss)
        {
            userProgram = usr;
            passProgram = pss;
            pages = new List<Page>();
        }





        //datos.Add(new string[] { "paginaApp", "user", "password", "correo", "other" });
        public List<Page> getDatosPersona()
        {
            return pages;
        }

        public void setDatosPersona(string paginaApp, string user, string password, string correo, string other)
        {
            Page p = new Page(paginaApp, user, password, correo, other);
            pages.Add(p);
        }

        public void Clear()
        {
            pages.Clear();
        }


        public override string ToString()
        {
            return "ID -> " + ID +
                    " UserProgram -> " + userProgram +
                    " PasswordProgram -> " + passProgram + "[ " +  pages.Imprimir() + " ]";
                    
        }

    }
}
