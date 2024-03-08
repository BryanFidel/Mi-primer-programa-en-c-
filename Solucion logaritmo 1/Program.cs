using System;

namespace Solucion_logaritmo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las coordenadas del primer punto:");
            Console.Write("Coordenada X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Coordenada Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese las coordenadas del segundo punto:");
            Console.Write("Coordenada X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Coordenada Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distancia = CalcularDistancia(x1, y1, x2, y2);

            Console.WriteLine($"\nLa distancia entre los dos puntos es: {distancia}");
        }

        static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }
    }
}
