namespace LibreriasJuego
{
    public class Pais: IPais
    {
        public Pais(IContinente continente, string nombre,string capital) {
            this.continente = continente;
            this.nombre = nombre;
            this.capital = capital;
        }
        public string nombre { get; }
        public string capital{ get; }
        public IContinente continente { get; }

    }
}