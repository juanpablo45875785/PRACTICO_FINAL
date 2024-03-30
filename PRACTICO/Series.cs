using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

namespace Practico
{
    public class Series 
    {
        static void Main(string[] args)
        {
            int n = 5; // Cambia este valor por el número de término de Fibonacci que desees obtener
            int resultado = Fibonacci(n);
            Console.WriteLine("0,1,1,2,3,5,8................");
            Console.WriteLine($"El {n}-ésimo término de Fibonacci es: {resultado}\n");

            int m = 5; // Cambia este valor por el número de término que desees obtener 
            int resultado1 = ObtenerNEsimoNumero(m);
            Console.WriteLine($"El {m}-ésimo número de la serie es: {resultado1}\n");
            
            int o = 5; // Cambia este valor por la cantidad de términos que deseas sumar
            int[] serie1 = {0, 2, 4, 6, 8, 10, 12, 14, 16}; // Cambia esta serie según sea necesario
            int suma = SumaSerie(o, serie1);
            Console.WriteLine("la serie es: " + string.Join(" ", serie1)+"...........");
            Console.WriteLine($"suma de los primeros {o} términos: {suma}\n");

            int p = 6; // Cambia este valor por el número de término que desees obtener 
            int resultado2 = ObtenerNEsimoNumero1(p);
            Console.WriteLine($"El {p}-ésimo número de la serie es: {resultado2}\n");

            int[] serie = { 1, 2, 3, 3, 4, 5, 6, 7, 7, 8 };
            int q = 2; // Número de términos a considerar
            int termino = 2; // Valor del término para buscar los pares
            int sumaParesPrimerosN = SumaTerminosParesPrimerosN(serie, q, termino);
            Console.WriteLine($"La suma de los términos pares de los primeros {q} términos de la serie es: {sumaParesPrimerosN}");
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /*devuelve el n-ésimo numero de la serie*/
        static int ObtenerNEsimoNumero(int m)
        {
            int[] serie = {1,2,3,6,7,14,15,30,31,45,76};
            Console.WriteLine("la serie es: " + string.Join(" ", serie)+"...........");
            int longitudSerie = serie.Length;
            // Si n es menor o igual a la longitud de la serie, devolvemos el carácter en la posición n-1
            if (m <= longitudSerie)
                return serie[m - 1];
            else
            {
                // Si n es mayor que la longitud de la serie, calculamos el índice de repetición
                int repeticiones = (m - longitudSerie) / 10;
                int indiceEnSerie = (m - longitudSerie) % 10;
                // Devolvemos el carácter en la posición calculada
                return serie[indiceEnSerie];
            }
        }

        /*suma de los primeros n terminos de la serie */
        static int SumaSerie(int o, int[] serie)
        {
            // Inicializamos la suma en 0
            int suma = 0;
            // Iteramos sobre los primeros n términos de la serie
            for (int i = 0; i < o; i++)
            {
                // Añadimos cada término de la serie a la suma total
                suma += serie[i];
            }
            // Devolvemos la suma total
            return suma;
        }

        /*devuelve el n-ésimo numero de la serie2*/
        static int ObtenerNEsimoNumero1(int p)
        {
            int[] serie = {1, 3, 7, 15,31,63,127,255};
            Console.WriteLine("la serie es: " + string.Join(" ", serie)+".........");
            int longitudSerie = serie.Length;
            // Si n es menor o igual a la longitud de la serie, devolvemos el carácter en la posición n-1
            if (p <= longitudSerie)
                return serie[p - 1];
            else
            {
                // Si n es mayor que la longitud de la serie, calculamos el índice de repetición
                int repeticiones = (p - longitudSerie) / 10;
                int indiceEnSerie = (p - longitudSerie) % 10;
                // Devolvemos el carácter en la posición calculada
                return serie[indiceEnSerie];
            }
        }

        static int SumaTerminosParesPrimerosN(int[] serie, int q, int termino)
        {
            int suma = 0;
            int contador = 0;

            foreach (int numero in serie)
            {
                if (contador >= q)
                {
                    break; // Si ya hemos revisado los primeros n términos, salimos del bucle
                }

                if (numero % termino == 0)
                {
                    suma += numero;
                    contador++;
                }
            }

            return suma;
        }
    
    }
}