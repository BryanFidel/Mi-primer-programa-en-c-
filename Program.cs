using System;

namespace Mi_primer_programa_de_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            
            double cuadrado = Math.Pow(num1, 2);
            double raizCuadrada = Math.Sqrt(num2);
            double raizCubica = Math.Pow(num3, 1.0 / 3.0);

            
            Console.WriteLine("El cuadrado de {0} es: {1}", num1, cuadrado);
            Console.WriteLine("La raíz cuadrada de {0} es: {1}", num2, raizCuadrada);
            Console.WriteLine("La raíz cúbica de {0} es: {1}", num3, raizCubica);

            Console.ReadLine(); 
        }
    }
}

