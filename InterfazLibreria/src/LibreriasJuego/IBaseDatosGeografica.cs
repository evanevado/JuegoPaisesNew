using System;
using System.Collections.Generic;
using System.Text;


namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {

        public IPais getPais(string nombrePais);

        public IContinente getContinente(string nombreContinente);

        public IList<IContinente> getContinentes();
        
    }
}
