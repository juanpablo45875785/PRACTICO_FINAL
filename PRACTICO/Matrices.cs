using System;
namespace Practico
{
    public class Matrices
    {
        private int filas;
        private int columnas;
        private int[,] datos;

        public Matrices()
        {
            filas = 0;
            columnas = 0;
            datos = null;
        }
        
        public void Ejercicio1()
        {
            Console.WriteLine("Ingrese el número de filas:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            columnas = int.Parse(Console.ReadLine());
            datos = GenerarMatriz(filas, columnas);

            imprimir();
        }


        static int[,] GenerarMatriz(int filas, int columnas)
        {  
            int[,] matriz = new int[filas, columnas];
            int numero = 15;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (j <= i)
                    {
                        matriz[i, j] = numero--;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                }
            }

            return matriz;
        }
        public void Ejercicio2()
        {
            Console.WriteLine("Ingrese el número de filas:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            columnas = int.Parse(Console.ReadLine());
            datos = ejercicio2(filas, columnas);

            imprimir();
        }

        static int[,] ejercicio2(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas

            int numero = 1; // Inicializar el primer número a colocar

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = fila; columna < columnas; columna++) // Comenzar a colocar números desde la diagonal superior
                {
                    matriz[columna, fila] = numero++; // Asignar el número actual y luego incrementarlo
                }
            }

            return matriz;
        }
        public void Ejercicio3()
        {
            Console.WriteLine("Ingrese el número de filas:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            columnas = int.Parse(Console.ReadLine());
            datos = Serpiente(filas, columnas);

            imprimir();
        }

        static int[,] Serpiente(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];

            int valor = 1;
            for (int columna = 0; columna < columnas; columna++)
            {
                // Determinar la dirección de llenado de la fila (izquierda a derecha o derecha a izquierda)
                bool derecha = columna % 2 == 0;

                // Llenar la fila en la dirección determinada
                if (derecha)
                {
                    for (int fila = 0; fila < filas; fila++)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
                else
                {
                    for (int fila = filas - 1; fila >= 0; fila--)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
            }

            return matriz;
        }
        public void Ejercicio4()
        {
            Console.WriteLine("Ingrese el número de filas:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            columnas = int.Parse(Console.ReadLine());
            datos = GenerarCuadradoMagico(filas, columnas);

            imprimir();
        }

        static int[,] GenerarCuadradoMagico(int filas, int columnas)
        {
            int[,] cuadradoMagico = new int[filas, columnas];

            int numero = 1;
            int fila = 0;
            int columna = filas / 2;

            while (numero <= filas * columnas)
            {
                cuadradoMagico[fila, columna] = numero;
                numero++;

                int nuevaFila = (fila - 1 + filas) % columnas;
                int nuevaColumna = (columna + 1) % columnas;

                if (cuadradoMagico[nuevaFila, nuevaColumna] != 0)
                {
                    fila = (fila + 1) % columnas;
                }
                else
                {
                    fila = nuevaFila;
                    columna = nuevaColumna;
                }
            }

            return cuadradoMagico;
        }

        public void Ejercicio5()
        {
            Console.WriteLine("Ingrese el número de filas:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            columnas = int.Parse(Console.ReadLine());

            datos = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (j >= i)
                    {
                        datos[i, j] = columnas - j;
                    }
                    else
                    {
                        datos[i, j] = columnas - i;
                    }
                }
            }
            imprimir();
        }


        public void imprimir()
        {
            Console.WriteLine("ESTA ES LA MATRIZ GENERADA POR EL TAMAÑO QUE LE DISTE ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(datos[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
        }

    }
}