using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

namespace Practico
{
    public class Series 
    {
        
        public static void Ejercicio1()
        {
            // Mostramos la secuencia de Fibonacci inicial
            Console.WriteLine("Secuencia de Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13");

            // Solicitamos al usuario que ingrese la posición del término de Fibonacci que desea calcular
            Console.Write("Ingrese la posición del término de Fibonacci que desea calcular: ");
            int n = int.Parse(Console.ReadLine());

            // Calculamos el término de Fibonacci en la posición dada
            int resultado = Fibonacci(n);

            // Mostramos el resultado en la consola
            Console.WriteLine($"El {n}-ésimo término de Fibonacci es: {resultado}");
        }

        private static int Fibonacci(int n)
        {
            // Definimos la secuencia de Fibonacci manualmente
            int[] secuencia = {0, 1, 1, 2, 3, 5, 8, 13};

            // Validamos si la posición dada está dentro del rango de la secuencia manual
            if (n < 0 || n >= secuencia.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "La posición está fuera del rango de la secuencia.");
            }

            // Retornamos el valor en la posición dada
            return secuencia[n - 1]; // Ajustamos la posición para que empiece desde 1 en lugar de 0
        }
        public static void Ejercicio2()
        {
            // Mostramos la serie inicial
            int[] serie = {1, 2, 3, 6, 7, 14, 15, 30, 31};
            Console.WriteLine("Serie: " + string.Join(", ", serie));

            // Solicitamos al usuario que ingrese la posición del término de la serie que desea calcular
            Console.Write("Ingrese la posición del término de la serie que desea calcular: ");
            int n = int.Parse(Console.ReadLine());

            // Calculamos el término de la serie en la posición dada
            int resultado = ObtenerNEsimoNumero1(n, serie);

            // Mostramos el resultado en la consola
            Console.WriteLine($"El {n}-ésimo término de la serie es: {resultado}");
        }

        private static int ObtenerNEsimoNumero1(int n, int[] serie)
        {
            // Validamos si la posición dada está dentro del rango de la serie
            if (n < 1 || n > serie.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "La posición está fuera del rango de la serie.");
            }

            // Retornamos el valor en la posición dada
            return serie[n - 1];
        }
    

        /*devuelve el n-ésimo numero de la serie*/
        public static void Ejercicio3()
        {
            int[] serie = {0,2,4,6,8,10,12,14,16,18,20};
            Console.WriteLine("La serie es: " + string.Join(" ", serie));

            // Solicitamos al usuario que ingrese la cantidad de términos que desea sumar
            Console.Write("Ingrese la cantidad de términos que desea sumar: ");
            int o = int.Parse(Console.ReadLine());

            // Calculamos la suma de los primeros n términos de la serie
            int suma = SumaSerie(o, serie);

            // Mostramos la suma en la consola
            Console.WriteLine($"La suma de los primeros {o} términos es: {suma}");
        }

        private static int SumaSerie(int n, int[] serie)
        {
            // Inicializamos la suma en 0
            int suma = 0;

            // Iteramos sobre los primeros n términos de la serie
            for (int i = 0; i < n; i++)
            {
                // Añadimos cada término de la serie a la suma total
                suma += ObtenerNEsimoNumero(i + 1, serie);
            }

            // Devolvemos la suma total
            return suma;
        }

        private static int ObtenerNEsimoNumero(int m, int[] serie)
        {
            int longitudSerie = serie.Length;
            // Si m es menor o igual a la longitud de la serie, devolvemos el elemento en la posición m-1
            if (m <= longitudSerie)
                return serie[m - 1];
            else
            {
                // Si m es mayor que la longitud de la serie, calculamos el índice de repetición
                int repeticiones = (m - longitudSerie) / 10;
                int indiceEnSerie = (m - longitudSerie) % 10;
                // Devolvemos el elemento en la posición calculada
                return serie[indiceEnSerie];
            }
        }
     
        public static void Ejercicio4()
        {
            // Mostramos la serie inicial
            int[] serie = {1,3,7,15,31,63,127,255};
            Console.WriteLine("Serie: " + string.Join(", ", serie));

            // Solicitamos al usuario que ingrese la posición del término de la serie que desea calcular
            Console.Write("Ingrese la posición del término de la serie que desea calcular: ");
            int n = int.Parse(Console.ReadLine());

            // Calculamos el término de la serie en la posición dada
            int resultado = ObtenerNEsimoNumero4(n, serie);

            // Mostramos el resultado en la consola
            Console.WriteLine($"El {n}-ésimo término de la serie es: {resultado}");
        }

        private static int ObtenerNEsimoNumero4(int n, int[] serie)
        {
            // Validamos si la posición dada está dentro del rango de la serie
            if (n < 1 || n > serie.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "La posición está fuera del rango de la serie.");
            }

            // Retornamos el valor en la posición dada
            return serie[n - 1];
        }
        public static void Ejercicio5()
        {
            int[] serie = { 1, 2, 4, 5, 10, 12, 13, 26, 28, 29 };
            Console.WriteLine("Serie: " + string.Join(", ", serie));

            Console.Write("Ingrese la posición hasta donde desea sumar: ");
            int posicion = int.Parse(Console.ReadLine());

            int sumaParesHastaPosicion = SumaParesHastaPosicion(serie, posicion);
            Console.WriteLine($"La suma de los términos pares hasta la posición {posicion} es: {sumaParesHastaPosicion}");
        }

        private static int SumaParesHastaPosicion(int[] serie, int posicion)
        {
            int suma = 0;
            int contador = 0;

            foreach (int numero in serie)
            {
                if (contador == posicion)
                    break;

                if (numero % 2 == 0)
                {
                    suma += numero;
                }

                contador++;
            }

            return suma;
        }
    }
}