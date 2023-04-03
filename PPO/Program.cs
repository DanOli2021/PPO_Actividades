using System;

int opcion = 0;

while( true )
{
    Console.WriteLine("Seleccione la figura para calcular el área: ");
    Console.WriteLine("1. Triángulo");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Círculo");
    Console.WriteLine("4. Trapecio");
    Console.WriteLine("5. Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese la base del triángulo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El área del triángulo es: {Areas.area(b, h)}");
            break;
        case 2:
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El área del cuadrado es: {Areas.area(lado)}");
            break;
        case 3:
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El área del círculo es: {Areas.area(true, radio)}");
            break;
        case 4:
            Console.Write("Ingrese la base menor del trapecio: ");
            double bmenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la base mayor del trapecio: ");
            double bmayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del trapecio: ");
            double alt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El área del trapecio es: {Areas.area(bmenor, bmayor, alt)}");
            break;
        case 5:
            Console.WriteLine("Adiós");
            return;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    Console.WriteLine();
}



