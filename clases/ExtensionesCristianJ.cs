using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public static class ExtensionesCristianJ
    {

        public static string Imprimir<T>(this IEnumerable<T> lista)//( this List<T> lista)where T: Page
        {
            string resultado = string.Empty;
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    resultado += item.ToString() + " ,";
                }
                return resultado;
            }
            else
            {
                return "Lista vacia";
            }
        }
    }
}
