using System;
namespace Practico
{

public class Vectores
{
    
    public static void ejercicio1()
    {
    
        Console.WriteLine("Ingrese los números del vector (ejercicio1)");
        string entrada = Console.ReadLine();
        string[] entradaNumeros = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        int[] numeros = new int[entradaNumeros.Length];
        for (int i = 0; i < entradaNumeros.Length; i++)
        {
            if (!int.TryParse(entradaNumeros[i].Trim(), out numeros[i]))
            {
                Console.WriteLine("Error: Por favor, ingrese solo números válidos.");
                return;
            }
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
//------------------------------------------------------
//EJERCICIO 2
        public static void ejercicio2()
    {
        Console.WriteLine("Ingrese los números del vector para ordenarlos con el algoritmo MergeSort (ejercicio2)");
        string entrada = Console.ReadLine();
        string[] entradaNumeros = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] vector = new int[entradaNumeros.Length];
        for (int i = 0; i < entradaNumeros.Length; i++)
        {
            if (!int.TryParse(entradaNumeros[i].Trim(), out vector[i]))
            {
                Console.WriteLine("Error: Por favor, ingrese solo números válidos.");
                return;
            }
        }

        MergeSort(vector, 0, vector.Length - 1);

        Console.WriteLine("\nVector ordenado:");
        ImprimirVector(vector);
    }

    static void MergeSort(int[] vector, int izquierda, int derecha)
    {
        if (izquierda < derecha)
        {
            int medio = (izquierda + derecha) / 2;

            MergeSort(vector, izquierda, medio);
            MergeSort(vector, medio + 1, derecha);

            Merge(vector, izquierda, medio, derecha);
        }
    }

    static void Merge(int[] vector, int izquierda, int medio, int derecha)
    {
        int n1 = medio - izquierda + 1;
        int n2 = derecha - medio;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = vector[izquierda + i];
        for (int j = 0; j < n2; j++)
            R[j] = vector[medio + 1 + j];

        int k = izquierda;
        int p = 0;
        int q = 0;

        while (p < n1 && q < n2)
        {
            if (L[p] <= R[q])
            {
                vector[k] = L[p];
                p++;
            }
            else
            {
                vector[k] = R[q];
                q++;
            }
            k++;
        }

        while (p < n1)
        {
            vector[k] = L[p];
            p++;
            k++;
        }

        while (q < n2)
        {
            vector[k] = R[q];
            q++;
            k++;
        }
    }

    static void ImprimirVector(int[] vector)
    {
        foreach (var item in vector)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
//---------------------------------------------------------------------------
//ejercicio 3

    public static void ejercicio3()
    {
        Console.WriteLine("Ingrese los números del vector para ordenarlos con el algoritmo InsertionSort (ejercicio3) ");
        string entrada = Console.ReadLine();
        string[] entradaNumeros = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] vector = new int[entradaNumeros.Length];
        for (int i = 0; i < entradaNumeros.Length; i++)
        {
            if (!int.TryParse(entradaNumeros[i].Trim(), out vector[i]))
            {
                Console.WriteLine("Error: Por favor, ingrese solo números válidos.");
                return;
            }
        }

        InsertionSort(vector);

        Console.WriteLine("\nVector ordenado:");
        ImprimirVector(vector);
    }

    static void InsertionSort(int[] vector)
    {
        for (int i = 1; i < vector.Length; i++)
        {
            int key = vector[i];
            int j = i - 1;

            while (j >= 0 && vector[j] > key)
            {
                vector[j + 1] = vector[j];
                j = j - 1;
            }
            vector[j + 1] = key;
        }
    }
//--------------------------------------------------------------------------------
//Ejercicio 4
    public static void ejercicio4()
    {
        Console.WriteLine("Ingrese los números del vector (ejercicio4)");
        string entrada = Console.ReadLine();
        string[] entradaNumeros = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] vector = new int[entradaNumeros.Length];
        for (int i = 0; i < entradaNumeros.Length; i++)
        {
            if (!int.TryParse(entradaNumeros[i].Trim(), out vector[i]))
            {
                Console.WriteLine("Error: Por favor, ingrese solo números válidos.");
                return;
            }
        }

        Console.WriteLine("Ingrese el valor a eliminar:");
        int x;
        if (!int.TryParse(Console.ReadLine().Trim(), out x))
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido para eliminar.");
            return;
        }

        Console.WriteLine("\nVector original:");
        ImprimirVector(vector);

        EliminarX(ref vector, x);

        Console.WriteLine("\nVector después de eliminar " + x + ":");
        ImprimirVector(vector);
    }

    static void EliminarX(ref int[] vector, int x)
    {
        int newSize = 0;

        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] != x)
            {
                vector[newSize] = vector[i];
                newSize++;
            }
        }

        Array.Resize(ref vector, newSize);
    }

 
//----------------------------------------------------------------------------------------
//ejercicio5
public static void ejercicio5()
    {
        Console.WriteLine("Ingrese los números del vector (ejercicio5) ");
        string entrada = Console.ReadLine();
        string[] entradaNumeros = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] vector = new int[entradaNumeros.Length];
        for (int i = 0; i < entradaNumeros.Length; i++)
        {
            if (!int.TryParse(entradaNumeros[i].Trim(), out vector[i]))
            {
                Console.WriteLine("Error: Por favor, ingrese solo números válidos.");
                return;
            }
        }

        Console.WriteLine("Ingrese el valor de 'a':");
        int a;
        if (!int.TryParse(Console.ReadLine().Trim(), out a))
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido para 'a'.");
            return;
        }

        Console.WriteLine("Ingrese el valor de 'b':");
        int b;
        if (!int.TryParse(Console.ReadLine().Trim(), out b))
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido para 'b'.");
            return;
        }

        Console.WriteLine("\nVector original:");
        ImprimirVector(vector);

        InvertirParte(ref vector, a, b);

        Console.WriteLine("\nVector después de invertir entre las posiciones " + a + " y " + b + ":");
        ImprimirVector(vector);
    }

    static void InvertirParte(ref int[] vector, int a, int b)
    {
        if (a < 0 || b >= vector.Length || a >= b)
        {
            Console.WriteLine("Error: Posiciones no válidas para invertir.");
            return;
        }

        while (a < b)
        {
            int temp = vector[a];
            vector[a] = vector[b];
            vector[b] = temp;
            a++;
            b--;
        }
    }


}
}


