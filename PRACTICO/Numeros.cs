using System;

namespace Practico
{
    public class Numeros
    {
        public static void Ejercicio1()
        {
            Console.WriteLine("Ingrese un número entero positivo: (Ejericio1)");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int mayorDigito = MayorDigito(numero);
                Console.WriteLine("El mayor dígito es: " + mayorDigito +  "\n");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
            }
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

        public static void Ejercicio2()
        {
            Console.WriteLine("Ingrese un número entero positivo: (Ejericio2)");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int sumaPares = SumaDigitosPares(numero);
                Console.WriteLine($"La suma de los dígitos pares de {numero} es el numero : {sumaPares}"+  "\n");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
            }
        }

        static int SumaDigitosPares(int numero)
        {
            int suma = 0;
            while (numero > 0)
            {
                int digito = numero % 10;
                if (digito % 2 == 0)
                {
                    suma += digito;
                }
                numero /= 10;
            }
            return suma;
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("Ingrese un número entero positivo: (Ejericio3)");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int resultado = MoverMayorDigitoAlFinal(numero);
                Console.WriteLine($"Número original: {numero}, Número reorganizado: {resultado}" +  "\n");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
            }
        }

        static int MoverMayorDigitoAlFinal(int numero)
        {
            if (numero < 10) return numero;

            int numeroOriginal = numero;
            int maxDigito = 0;
            int multiplicador = 1;
            int resultado = 0;

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

            while (numero > 0)
            {
                int digito = numero % 10;
                if (digito == maxDigito && !maxDigitoRemovido)
                {
                    maxDigitoRemovido = true;
                }
                else
                {
                    resultado += digito * multiplicador;
                    multiplicador *= 10;
                }
                numero /= 10;
            }

            resultado += maxDigito * multiplicador;

            return resultado;
        }

        public static void Ejercicio4()
        {
            Console.WriteLine("Ingrese un número entero positivo: (Ejericio4)");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine($"El número {numero} está ordenado: {EstanDigitosOrdenados(numero)}" +  "\n");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
            }
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
                    return false;
                }
                digitoAnterior = digitoActual;
                numero /= 10;
            }

            return true;
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("Ingrese un número entero positivo: (Ejericio5)");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int cantidadImparesAntesDePar = ContarImparesAntesDePar(numero);
                Console.WriteLine($"Cantidad de dígitos impares antes del primer dígito par: {cantidadImparesAntesDePar}" +  "\n");
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
                        break;
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

        
