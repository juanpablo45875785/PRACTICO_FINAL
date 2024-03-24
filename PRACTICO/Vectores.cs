using System;

namespace Practico
{
    public class Vectores
    {
        public void ejercicio1()
        {
           

            Console.WriteLine("Ingrese los números separados por comas:");
            string[] entradaNumeros = Console.ReadLine().Split(',');

            int[] numeros = new int[entradaNumeros.Length];
            for (int i = 0; i < entradaNumeros.Length; i++)
            {
                numeros[i] = int.Parse(entradaNumeros[i].Trim());
            }

            int contadorPares = 0;

            foreach (int numero in numeros)
            {
                if (EsPar(numero))
                {
                    contadorPares++;
                }
            }

            Console.WriteLine("La cantidad de numeros pares es: " + contadorPares);
        }

        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
    }

}

    
