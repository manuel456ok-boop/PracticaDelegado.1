using System;

class Program
{
    static void Main()
    {
        var calc = new Calculadora();

        Console.WriteLine("=== Calculadora con Delegados ===");
        Console.WriteLine("Operaciones: 1-Sumar  2-Restar  3-Multiplicar  4-Dividir");
        Console.WriteLine("Ingrese 0 para salir.");

        while (true)
        {
            Console.Write("\nSeleccione operación: ");
            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                Console.WriteLine("Saliendo...");
                break;
            }

            Console.Write("Ingrese el primer número: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
                continue;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
                continue;
            }

            // Asignación dinámica del delegado según la opción
            Calculadora.OperacionMatematica operacion = calc.ObtenerOperacion(opcion);

            if (operacion == null)
            {
                Console.WriteLine("Opción no válida.");
                continue;
            }

            try
            {
                // Ejecución usando el delegado
                int resultado = operacion(a, b);
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
