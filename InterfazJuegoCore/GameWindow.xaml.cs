using LibreriasJuego;
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
    public partial class GameWindow : Window
    {

        private IPartida partida;
        private IPregunta preguntaActual;

        public GameWindow(IPartida partida)
        {
            InitializeComponent();
            this.partida = partida;
            nuevaPregunta();
        }

        private void nuevaPregunta() {
            preguntaActual=partida.nuevaPregunta();
            lbl_Pais.Content = preguntaActual.pais.nombre;
            txt_Capital.Text = "";
            lbl_Intentos.Content = preguntaActual.intentosRestantes;
            int total=partida.historicoPreguntas.Count();
            int aciertos=0;
            partida.historicoPreguntas.ForEach(
                (pregunta) => {if (pregunta.acierto)  aciertos++;}
            );
            lbl_Estadisticas.Content = 
                "Llevas " + aciertos + " aciertos de " + total + "preguntas";
        }

        private void btn_Finalizar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Probar_Click(object sender, RoutedEventArgs e)
        {
            string capitalPropuesta = txt_Capital.Text;
            bool acerte=
                preguntaActual.proponerRespuesta(capitalPropuesta);
            if (acerte || preguntaActual.intentosRestantes == 0)
                nuevaPregunta();
            else {
                txt_Capital.Text = "";
                lbl_Intentos.Content = preguntaActual.intentosRestantes;
            }
        }
    }
}
