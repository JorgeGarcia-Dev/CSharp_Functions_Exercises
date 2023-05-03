/*
Escribir una función que tome un carácter y devuelva True si es una vocal,
de lo contrario devuelve False.
*/

using System;

namespace funciones5
{
    class Program
    {
        static bool EsVocal(char letra)
        {
            if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce un carácter:");
            char letra = Convert.ToChar(Console.ReadLine());
            bool resultado = EsVocal(letra);
            System.Console.WriteLine($"¿Es vocal? = {resultado}");
        }
    }
}