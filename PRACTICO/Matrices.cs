using System;
namespace Practico
{
    public class Matrices
    {
        private int filas;
        private int columnas;
        private int[,] datos;

        public Matrices(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            datos = new int[filas, columnas];
            
        }
        public void Ejercicio2()
        {
            for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            int valor;
            // Calculamos el valor basado en la posición en la matriz
            if (i % 2 == 0)
            {
                if (j % 2 == 0)
                {
                    valor = (columnas * i) + j + 1;
                }
                else
                {
                    valor = (columnas * (i + 1)) - j;
                }
            }
            else
            {
                if (j % 2 == 0)
                {
                    valor = (filas * (i * 1)) - j;
                }
                else
                {
                    valor = (columnas * i) * j + 1;
                }
            }
            // Imprimimos el valor
            Console.Write($"{valor, 3} ");
        }
        Console.WriteLine();
    }
            
        }

       
        public void Ejercicio5()
        {
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
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(datos[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}