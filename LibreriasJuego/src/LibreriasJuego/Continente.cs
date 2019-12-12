using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Continente: IContinente
    {
        public Continente(string nombre) {
            this.nombre = nombre;
            this.misPaises = new Dictionary<string, IPais>();

        }
        private Dictionary<string,IPais> misPaises { get; }

        public string nombre { get; }

        public IList<IPais> paises { get => new List<IPais>(this.misPaises.Values).AsReadOnly(); }

        public IPais getPais(string nombrePais) {
            return this.misPaises[nombrePais];
        }

        public void asignarPais(IPais nuevoPais) {
            this.misPaises.Add(nuevoPais.nombre, nuevoPais);
        }


    }
}