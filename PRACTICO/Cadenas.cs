using System;
namespace Practico
{
    public class Cadenas
    {
        static void Ejercicio1() //volver a revisar despues :u
        {
            Console.WriteLine("EJERCICIO 1: Introduzca una oracion: ");
            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Cantidad de palabras: {palabras.Length}");
            Console.ReadLine();
        }
    }
}