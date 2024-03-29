using System;

namespace Practico
{
    public class Numeros
    {
        public static void Main(string[] args)
        {
            int numero = 12345;
            int mayorDigito = MayorDigito(numero);
            Console.WriteLine("El mayor dígito de " + numero + " es: " + mayorDigito);
        }

        static int MayorDigito(int numero)
        {
            int mayor = 0;
            while (numero > 0)
            {
                int digito = numero % 10;
                if (digito > mayor)
                {
                    mayor = digito;
                }
                numero /= 10;
            }
            return mayor;
        }
    }
        namespace Ejercio2 // Cambia "TuNamespace" por el nombre de tu namespace
        {
            class Program
            {
                // El punto de entrada del programa debe ser el método Main
                static void Main(string[] args)
                {
                    int numero = 123456;
                    int sumaPares = SumaDigitosPares(numero);
                    Console.WriteLine($"La suma de los dígitos pares de {numero} es: {sumaPares}");
                }

                static int SumaDigitosPares(int numero)
                {
                    int suma = 0;
                    while (numero > 0)
                    {
                        int digito = numero % 10;
                        if (digito % 2 == 0) // Verifica si el dígito es par
                        {
                            suma += digito;
                        }
                        numero /= 10; // Remueve el último dígito del número
                    }
                    return suma;
                }
            }
        }
        namespace Ejercicio3
        {
            class Program

{
            static void Main()
            {
                int numero = 9287346;
                int resultado = MoverMayorDigitoAlFinal(numero);
                Console.WriteLine($"Número original: {numero}, Número reorganizado: {resultado}");
            }

            static int MoverMayorDigitoAlFinal(int numero)
            {
                if (numero < 10) return numero; // Si el número es de un solo dígito, lo devuelve tal cual.

                int numeroOriginal = numero;
                int maxDigito = 0;
                int multiplicador = 1;
                int resultado = 0;

                // Encuentra el dígito más grande
                while (numero > 0)
                {
                    int digito = numero % 10;
                    if (digito > maxDigito)
                    {
                        maxDigito = digito;
                    }
                    numero /= 10;
                }

                numero = numeroOriginal;
                bool maxDigitoRemovido = false;

                // Reconstruye el número sin el dígito más grande
                while (numero > 0)
                {
                    int digito = numero % 10;
                    if (digito == maxDigito && !maxDigitoRemovido)
                    {
                        maxDigitoRemovido = true; // Se asegura de remover el dígito máximo solo una vez
                    }
                    else
                    {
                        resultado += digito * multiplicador;
                        multiplicador *= 10;
                    }
                    numero /= 10;
                }

                // Añade el dígito máximo al final
                resultado += maxDigito * multiplicador;

                return resultado;
            }
        }
        namespace ejercio4
        {
            class Program
            {
                    static void Main()
                    {
                        int numero = 123456;
                        Console.WriteLine($"El número {numero} está ordenado: {EstanDigitosOrdenados(numero)}");
                    }

                    static bool EstanDigitosOrdenados(int numero)
                    {
                        int digitoAnterior = numero % 10;
                        numero /= 10;

                        while (numero > 0)
                        {
                            int digitoActual = numero % 10;
                            if (digitoActual > digitoAnterior)
                            {
                                return false; // Si el dígito actual es mayor que el anterior, los dígitos no están ordenados
                            }
                            digitoAnterior = digitoActual;
                            numero /= 10;
                        }

                        return true; // Si no se encontró ningún par de dígitos desordenados, el número está ordenado
                    }
            }
        }
        namespace ejercio5
        {
            class Program
            {
                static void Main()
                {
                    Console.Write("Ingrese un número entero positivo: ");
                    int numero;
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        int cantidadImparesAntesDePar = ContarImparesAntesDePar(numero);
                        Console.WriteLine($"Cantidad de dígitos impares antes del primer dígito par: {cantidadImparesAntesDePar}");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
                    }
                }

                static int ContarImparesAntesDePar(int numero)
                {
                    int contadorImpares = 0;
                    bool encontradoPar = false;

                    while (numero > 0)
                    {
                        int digito = numero % 10;
                        if (digito % 2 != 0)
                        {
                            if (encontradoPar)
                            {
                                break; // Si ya se encontró un dígito par, se detiene el bucle
                            }
                            contadorImpares++;
                        }
                        else
                        {
                            encontradoPar = true;
                        }
                        numero /= 10;
                    }

                    return contadorImpares;
                }
            }
        }

    }
}
        
