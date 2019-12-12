using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src.LibreriasJuego
{
    class Dummy
    {

        public static void Main() 
        {
            pintarEvaluacion(cuadrado, 5);
            pintarEvaluacion((numero)=>numero*numero, 5);
            pintarEvaluacion(tercio, 5);
            pintarEvaluacion((j) => j / 3, 5);
        }

        public static int tercio(int j)
        {
            return j/3;
        }

        public static int cuadrado(int x)
        {
            return x * x;
        }

        public static void pintarEvaluacion(Func<int,int> funcion, int x) {
            Console.WriteLine(funcion.Method.Name);
            int resultado = funcion(x);
            int resultado2 = funcion(x-1);
            int resultado3 = funcion(x+1);
            Console.WriteLine("El resultdo es"+resultado);
        }

    }
}
