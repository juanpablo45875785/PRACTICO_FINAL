using System;
namespace Practico
{
    public class Cadenas
    //CarlosEdgar //Ya Funciona :D
    {
        public static void Ejercicio1()
        {
            Console.WriteLine("EJERCICIO 1: Ingrese una Oración:");
            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine();
            Console.WriteLine("Respuesta.- Cantidad de palabras: " + palabras.Length);
            Console.WriteLine();
        }
        public static void Ejercicio2()
        {
            string letras, resultado;
            Console.WriteLine("EJERCICIO 2: Ingrese una oración:");
            letras = Console.ReadLine();
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            resultado = string.Concat(letras.Split(vocales));
            Console.WriteLine();
            Console.WriteLine("Respuesta.- Oracion sin vocales: " + resultado);
            Console.WriteLine();

        }
        public static void Ejercicio3()
        {
            Console.WriteLine("EJERCICIO 3: Ingrese una Oracion:");
            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split(' ');
            string palabraMasLarga = "";
            foreach (string palabra in palabras)
            {
                if (palabra.Trim().Length > palabraMasLarga.Length)
                {
                    palabraMasLarga = palabra.Trim();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Respuesta.- Palabra más larga: " + palabraMasLarga);
            Console.WriteLine();

        }
        public static void Ejercicio4()
        {
            Console.WriteLine("EJERCICIO 4: Ingrese una Oracion:");
            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] palabrasSinPrimerasLetras = new string[palabras.Length];
            for (int i = 0; i < palabras.Length; i++)
            {
                palabrasSinPrimerasLetras[i] = palabras[i].Substring(1);
            }
            string resultado = string.Join(" ", palabrasSinPrimerasLetras);
            Console.WriteLine();
            Console.WriteLine("Respuesta.- Oracion sin las primeras Letras " + resultado);
            Console.WriteLine();
        }
        public static void Ejercicio5()
        {
            Console.WriteLine("EJERCICIO 5: Ingrese una Oracion:");
            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] palabrasInvertidas = new string[palabras.Length];
            for (int i = 0; i < palabras.Length; i++)
            {
                palabrasInvertidas[i] = new string(palabras[i].ToCharArray().Reverse().ToArray());
            }
            string resultado = string.Join(" ", palabrasInvertidas);
            Console.WriteLine();
            Console.WriteLine("Respuesta.- Palabras invertidas de la Oracion: " + resultado);
            Console.WriteLine();
        } 
    }
}