// Shape.cs
using System;

public class Shape
{
    private string _color;

    // Constructor que acepta el color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter para el color
    public string GetColor()
    {
        return _color;
    }

    // Setter para el color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Método virtual para GetArea() que será sobrescrito
    public virtual double GetArea()
    {
        // Se devuelve 0 porque la forma base no tiene un área específica
        return 0;
    }
}