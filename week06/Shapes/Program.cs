// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crea una lista de objetos 'Shape' para demostrar el polimorfismo
        List<Shape> shapes = new List<Shape>();

        // Crea instancias de las clases derivadas y las añade a la lista de formas
        shapes.Add(new Square("Rojo", 5));
        shapes.Add(new Rectangle("Azul", 4, 6));
        shapes.Add(new Circle("Verde", 3));
        shapes.Add(new Square("Amarillo", 8));
        shapes.Add(new Rectangle("Púrpura", 10, 2));

        Console.WriteLine("--- Cálculo de Áreas de Formas ---");
        Console.WriteLine("----------------------------------");

        // Itera a través de la lista de formas y llama a GetArea()
        // El programa sabe automáticamente qué método GetArea() llamar para cada forma
        foreach (Shape shape in shapes)
        {
            // La variable 'shape' es del tipo base 'Shape', pero el programa
            // llama a la implementación correcta del método 'GetArea'
            // de la clase derivada. Esto es polimorfismo en acción.
            Console.WriteLine($"La forma de color {shape.GetColor()} tiene un área de {shape.GetArea():F2}");
        }

        Console.WriteLine("----------------------------------");
    }
}