using System;

namespace funciones3
{
    class Program
    {
        static int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce el primer sumando:");
            int sumando1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Introduce el segundo sumando:");
            int sumando2 = Convert.ToInt32(Console.ReadLine());
            int resultado = Sumar(sumando1, sumando2);
            System.Console.WriteLine($"El resultado de la suma es: {resultado}");
        }
    }
}