/*
Definir una función max() que tome como argumento dos números y devuelva el mayor de ellos.
*/

using System;

namespace funciones4
{
    class Program
    {
        static int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Introduce el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = Max(num1, num2);
            System.Console.WriteLine($"El mayor de los dos números es: {resultado}");
        }
    }
}
