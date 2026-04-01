using System;
using System.Collections.Generic;

class Calculadora
{
    public delegate int OperacionMatematica(int a, int b);

    private readonly Dictionary<string, OperacionMatematica> _operaciones;

    public Calculadora()
    {
        _operaciones = new Dictionary<string, OperacionMatematica>
        {
            { "1", Sumar },
            { "2", Restar },
            { "3", Multiplicar },
            { "4", Dividir }
        };
    }

    public OperacionMatematica ObtenerOperacion(string opcion)
    {
        return _operaciones.TryGetValue(opcion, out var op) ? op : null;
    }

    public static int Sumar(int a, int b) => a + b;
    public static int Restar(int a, int b) => a - b;
    public static int Multiplicar(int a, int b) => a * b;
    public static int Dividir(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("División por cero.");
        return a / b;
    }
}
