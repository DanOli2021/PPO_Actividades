using System;

Persona persona = new Persona();

Console.Write("Ingrese el nombre de la persona: ");
persona.nombre = Console.ReadLine();

Console.Write("Ingrese la edad de la persona: ");
persona.edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el sexo de la persona (M/F): ");
persona.sexo = Convert.ToChar(Console.ReadLine());

imprimir(persona);


static void imprimir(Persona persona_imp)
{
    Console.WriteLine("Nombre: " + persona_imp.nombre);
    Console.WriteLine("Edad: " + persona_imp.edad);
    Console.WriteLine("Sexo: " + persona_imp.sexo);
}