using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Jugador : IJugador
    {
        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.historicoPartidas = new List<IPartida>();
        }

        public string nombre { get; }

        public List<IPartida> historicoPartidas { get; }

        public IPartida nuevaPartida(IContinente continenteElegido) {
            Partida p = new Partida(this,continenteElegido);
            this.historicoPartidas.Add(p);
            return p;
        }
    }
}
