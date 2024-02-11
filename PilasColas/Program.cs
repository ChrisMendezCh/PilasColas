using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Usando una pila para almacenar elementos
        Stack<int> pila = new Stack<int>();

        // Usando una cola para almacenar elementos
        Queue<string> cola = new Queue<string>();

        // Agregar elementos a la pila
        pila.Push(1);
        pila.Push(2);
        pila.Push(3);

        // Agregar elementos a la cola
        cola.Enqueue("a");
        cola.Enqueue("b");
        cola.Enqueue("c");

        // Mostrar elementos de la pila
        Console.WriteLine("Elementos de la pila:");
        foreach (int num in pila)
        {
            Console.WriteLine(num);
        }

        // Mostrar elementos de la cola
        Console.WriteLine("\nElementos de la cola:");
        foreach (string letra in cola)
        {
            Console.WriteLine(letra);
        }
    }
}
