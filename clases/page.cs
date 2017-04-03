using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Page
    {
        public string PaginaApp { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Correo { get; set; }
        public string Other { get; set; }

        public Page()
        {

        }
         
        public Page(string pag,string user, string pass, string email, string otros)
        {
            PaginaApp = pag;
            User = user;
            Password = pass;
            Correo = email;
            Other = otros;
        }

        public override string ToString()
        {
            return "PaginaApp -> " + PaginaApp + 
                    " User -> " + User + 
                    " Password -> " + Password + 
                    " Correo -> " + Correo + 
                    " Other -> " + Other;
        }


    }
}
