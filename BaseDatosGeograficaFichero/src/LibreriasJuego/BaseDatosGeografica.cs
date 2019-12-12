using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;


namespace LibreriasJuego
{
    public class BaseDatosGeografica: IBaseDatosGeografica
    {
        public BaseDatosGeografica() {
            this.paises = new Dictionary<string, IPais>();
            this.continentes = new Dictionary<string, IContinente>();
            popularBaseDatos();
        }

        private Dictionary<string, IPais> paises;
        private Dictionary<string, IContinente> continentes;

        public IPais getPais(string nombrePais) {
            return this.paises[nombrePais];
        }

        public IContinente getContinente(string nombreContinente) {
            return this.continentes[nombreContinente];
        }

        public IList<IContinente> getContinentes() {
            return new List<IContinente>(this.continentes.Values).AsReadOnly();
        }

        private void popularBaseDatos()
        {
            List<string> nombresContinentes = new List<string>();
            nombresContinentes.Add("Africa");
            nombresContinentes.Add("America");
            nombresContinentes.Add("Asia");
            nombresContinentes.Add("Europa");
            nombresContinentes.Add("Oceania");

            foreach (string nombre in nombresContinentes)
            {
                // Crear Continente
                Continente c = new Continente(nombre);
                this.continentes.Add(nombre, c);
                
                // Leer fichero por continente
                string path = Path.Combine(
                    Path.GetDirectoryName(
                        Assembly.GetExecutingAssembly().Location)
                    , @"continentes\"+nombre+".txt");

                string[] lineas = File.ReadAllLines(path);

                // Crear Paises
                foreach (string linea in lineas) {
                    IPais p=procesarLineaPais(linea, c);
                    // Almacenarlo
                    if(!this.paises.ContainsKey(p.nombre))
                        this.paises.Add(p.nombre, p); //Diccionario de paises
                    c.asignarPais(p);
                }

            }
        }
    

        private IPais procesarLineaPais(string linea, IContinente continente) {
            //Bielorrusia: Minsk - Rublo Bielorruso
            string[] partes = linea.Split(":");
            string nombre = partes[0].Trim();
            partes = partes[1].Split("-");
            string capital = partes[0].Trim();
            IPais p = new Pais(continente, nombre,capital);
            return p;
        }

        
    }
}
