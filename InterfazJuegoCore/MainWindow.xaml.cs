using LibreriasJuego;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace InterfazJuego
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Inicializar el juego
            Juego.dameElJuego();
            cargarContinentes();
        }

        private void cargarContinentes() {
            
            Juego.dameElJuego().baseDatosGeografica.getContinentes()
                .ToList().ForEach(
                (continente) => cmb_Continentes.Items.Add(continente.nombre)
            );

            
        }

        private void btn_Jugar_Click(object sender, RoutedEventArgs e)
        {
            var nombreJugador = txt_Jugador.Text;
            string  nombreContinente = (string)cmb_Continentes.SelectedItem;
            IContinente continente =
                Juego.dameElJuego().
                baseDatosGeografica.getContinente(nombreContinente);

 
            // Mirar si el Jugador existe, sino lo creo y 
            // Lo recupero
            IJugador jugador = Juego.dameElJuego().
                baseDatosJugadores.getOrCreateJugador(nombreJugador);

            // Crearle una partida
            IPartida partida = jugador.nuevaPartida(continente);

            GameWindow ventanaJuego = new GameWindow(partida);
            ventanaJuego.Show();
        }
    }
}
