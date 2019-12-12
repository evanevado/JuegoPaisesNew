using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropa_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count, 0);
        }

        [TestMethod]
        public void TestEuropa_España()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
        }
        [TestMethod]
        public void TestEuropa_Nueva_Zelanda()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            
           
            Assert.ThrowsException<KeyNotFoundException>(
                ()=>europa.getPais("Nueva Zelanda")
                );
        }

    }
}
