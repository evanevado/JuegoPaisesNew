using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IPartida
    {
        public IJugador jugador { get; }

        public IContinente continente { get; }

        public List<IPregunta> historicoPreguntas { get; }

        public IPregunta nuevaPregunta();
    }
}
