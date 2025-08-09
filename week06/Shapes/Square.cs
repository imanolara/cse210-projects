// Square.cs
using System;

public class Square : Shape
{
    private double _side;

    // Constructor que acepta el color y el lado, y llama al constructor base
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Sobrescribe el método GetArea() para calcular el área del cuadrado
    public override double GetArea()
    {
        return _side * _side;
    }
}