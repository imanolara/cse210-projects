// Rectangle.cs
using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor que acepta el color, largo y ancho, y llama al constructor base
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Sobrescribe el método GetArea() para calcular el área del rectángulo
    public override double GetArea()
    {
        return _length * _width;
    }
}