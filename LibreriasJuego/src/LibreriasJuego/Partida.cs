using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Partida:IPartida
    {

        static Random generadorNumerosAleatorios = new Random();

        internal Partida(IJugador jugador, IContinente continente) {
            this.jugador = jugador;
            this.continente = continente;
            this.historicoPreguntas = new List<IPregunta>();
        }

        public IJugador jugador { get; }

        public IContinente continente { get; }

        public List<IPregunta> historicoPreguntas { get; }

        public IPregunta nuevaPregunta() {
            IPais pais = null;
            
            int total=this.continente.paises.Count;
            double numeritoAleatorio = Partida.generadorNumerosAleatorios.NextDouble();
            int elElegido = (int)(numeritoAleatorio * total);
            pais = this.continente.paises[elElegido];

            IPregunta p = new Pregunta(this,pais);
            historicoPreguntas.Add(p);
            return p;
        }
    }
}
