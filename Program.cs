using System;
using ClasesAbstracts.model;

namespace ClasesAbstracts;
class Program
{
    static void Main(string[] args)
    {
        Cuadrado fig1 = new Cuadrado(20);
        Console.WriteLine($"El area del cuadrado es: {fig1.Area()} metros");
        Console.WriteLine($"El Perimetro del cuadrado es: {fig1.Perimetro()} metros");
        Rectangulo fig2 = new Rectangulo(10,5);
        Console.WriteLine($"El area del rectangulo es: {fig2.Area()} metros");
        Console.WriteLine($"El Perimetro del rectangulo es: {fig2.Perimetro()} metros");
    }
}
