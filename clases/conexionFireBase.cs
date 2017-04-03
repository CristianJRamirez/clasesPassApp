using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public static class conexionFireBase
    {
        public static string conexion = "https://passapp-a31f5.firebaseio.com/";
        /*
         * // Instalar este paquete para utilizar el FireBase
            Install-Package FirebaseDatabase.net
        */

            public static DatosPersona dp = null;
            public static List<DatosPersona> personas = null;

            /// <summary> Agregar Datos al Firebase  </summary>
            /// <returns></returns>
            public static async Task setDatosFB()
            {
                if (dp == null)
                {
                    dp = new DatosPersona();
                }

                var client = new FirebaseClient(conexion);
                var child = client.Child("Personas/");

                var p1 = await child.PostAsync(dp);
                dp.ID = p1.Key;
            }


            /// <summary> Devolver los Datos de las personas en la BBDD </summary>
            /// <returns></returns>
            public static async Task getJugadoresFB()
            {
                //if (personas == null)
                //{
                //    personas = new List<DatosPersona>();
                //}

                //var firebase = new FirebaseClient(conexion);

                //var listpersonas = await firebase.Child("Personas").OnceAsync<DatosPersona>();


                //// string msg = "";

                ////List<Jugador> players = new List<Jugador>();

                //foreach (var p1 in listpersonas)
                //{
                //    Page p = p1.Object;
                //    personas.Add(p);
                //    // msg += j.Nombre + "\n";
                //}

                //return players;
            }

            /*  public static async Task deleteJugadores(Jugador j)
                {
                    var client = new FirebaseClient(conexion);
                    var child = client.Child("jugadors/" + j.ID);

                    await child.DeleteAsync();
                    //jugador.Id = p1.Key;
                }
*/

     /*           //sin implementar, setear puntos de la liga actual para el jugador
                public static async Task setPuntosJugadorFB(Jugador j)
                {
                    var client = new FirebaseClient(conexion);
                    var child = client.Child("jugadors/" + j.ID);

                    var p1 = await child.PostAsync(jugador);
                    jugador.ID = p1.Key;
                }*/
    }
}
