namespace LibreriasJuego
{
    public interface IPais
    {
        public string nombre { get; }
        public string capital{ get; }
        public IContinente continente { get; }

    }
}