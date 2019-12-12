using System;
using System.Collections.Generic;
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

        }

        private void btn_Jugar_Click(object sender, RoutedEventArgs e)
        {
            var nombreJugador = txt_Jugador.Text;
            var continente = cmb_Continentes.SelectedItem;
            // Mirar si el Jugador existe, sino lo creo y 
            // Lo recupero

            // Crearle una partida

            GameWindow ventanaJuego = new GameWindow();
            ventanaJuego.Show();
        }
    }
}
