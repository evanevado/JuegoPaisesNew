using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugadores
    {
        [TestMethod]
        public void TestAltaJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                IJuego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.nuevoJugador("Ivan");
            Assert.IsNotNull(ivan);
        }
        [TestMethod]
        public void TestRecuperacionJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                IJuego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getJugador("Ivan");
            Assert.IsNotNull(ivan);
        }
        [TestMethod]
        public void TestAltaYRecuperacionJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                IJuego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Assert.IsNotNull(ivan);
        }
        [TestMethod]
        public void TestNombreJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                IJuego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Assert.AreEqual(ivan.nombre,"Ivan");
        }

    }
}
