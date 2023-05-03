/*
Desarrolla un programa que, dado un número entero, determine si es par, impar o igual.
*/

using System;

namespace funciones2
{
    class Program
    {
        static void EsMayorQueCero(int valor)
        {
            if(valor > 0)
            {
                System.Console.WriteLine("El valor es mayor que cero");
            }
            else if(valor == 0)
            {
                System.Console.WriteLine("El valor es igual que cero");
            }
            else
            {
                System.Console.WriteLine("El valor es menor");
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce un número entero:");
            int valorLeido = Convert.ToInt32(Console.ReadLine());
            EsMayorQueCero(valorLeido);
            Console.ReadLine();
        }
    }
}
