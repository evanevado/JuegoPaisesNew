using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IContinente
    {
        public string nombre{ get; }

        public IList<IPais> paises { get; }

        public IPais getPais(string nombrePais);


    }
}