using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    // cuando creemos un juego estamos obligados a decirle de qué tipo; ese tipo tiene que extender a IJuego (es lo que dice el where)
    // haremos una llamada de este estilo: Ijuego j = Ijuego<JuegoWebServices>.dameElJuego();
    public abstract class IJuego<T> where T:IJuego<T>
    {
        private static IJuego<T> instancia;
        // equivale a un semáforo
        // diferencia entre un readonly y tener sólo un get... readonly asegura que sólo va a coger un valor; cuando ya
        // tiene un valor, no se cambia.  
        private static readonly object testigo = new object();

        // sólo las instancias que yo me cree del juego va a poder hacer un set (decir qué base de datos vamos a utilizar)
        public IBaseDatosJugadores baseDatosJugadores { get; protected set; }
        public IBaseDatosGeografica baseDatosGeografica { get; protected set; }

        public static IJuego<T> dameElJuego() {
            // patrón de doble bloqueo.  Aseguramos ok un entorno de concurrencia
            if (instancia == null) {
                //cojo el testigo... no puede pasar nadie si ya hay alguien dentro
                lock(testigo)
                {
                    if (instancia == null)
                    {
                        // el createInstance equivale a un new                        
                        instancia = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }                
            }
            return instancia;
        }

    }
}
