using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Clase para el calculo de areas
/// </summary>
public static class Areas
{
    // Sobrecarga de métodos
    // Métodos con el mismo nombre pero con diferentes parámetros
    // El compilador elige el método a ejecutar en tiempo de ejecución
    // según los parámetros que se le pasen al método

    // Este método se selecciona si se trata de un triángulo 
    public static double area(double b, double h)
    {
        return (b * h) / 2;
    }

    // Este método se selecciona si se trata de un cuadrado
    public static double area(double lado)
    {
        return lado * lado;
    }

    // Este método se selecciona si se trata de un círculo
    public static double area(bool circulo, double radio)
    {
        return Math.PI * radio * radio;
    }


    // Este método se selecciona si se trata de un trapezoide o un rectangulo
    public static double area(double bmenor, double bmayor, double alt)
    {
        return ((bmenor + bmayor) * alt) / 2;
    }
}