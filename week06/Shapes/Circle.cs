// Circle.cs
using System;

public class Circle : Shape
{
    private double _radius;

    // Constructor que acepta el color y el radio, y llama al constructor base
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Sobrescribe el método GetArea() para calcular el área del círculo
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}