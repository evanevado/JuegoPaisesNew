using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Pregunta:IPregunta
    {
        internal Pregunta(IPartida partida, IPais pais) {
            this.partida = partida;
            this.pais = pais;
            this.intentosRestantes= 3;
            this.respuestasPropuestas = new List<string>();
            this.acierto = false;
        }
        public IPartida partida { get; }

        public IPais pais { get; }

        public bool proponerRespuesta(string capitalSugerida) {
            if (this.intentosRestantes == 0) {
                throw new Exception("Ruinaca... No te quedan intentos !");
            }
            this.respuestasPropuestas.Add(capitalSugerida);
            this.intentosRestantes--;
            this.acierto = (capitalSugerida == this.pais.capital);
            return this.acierto;
        }

        public int intentosRestantes { get; private set; }

        public List<string> respuestasPropuestas { get;}

        public bool acierto { get; private set; }

    }
}