using System;

// a) Clase base "Persona" con 3 atributos
public class Persona
{
	protected string nombre;
	protected DateTime fechaNacimiento;
	protected string direccion;

	public Persona(string nombre, DateTime fechaNacimiento, string direccion)
	{
		this.nombre = nombre;
		this.fechaNacimiento = fechaNacimiento;
		this.direccion = direccion;
	}
}

// b) Clase derivada "Cliente" que hereda de "Persona"
public class Cliente : Persona
{
	private int clienteID;
	private string correoElectronico;
	private string telefono;

	public Cliente(string nombre, DateTime fechaNacimiento, string direccion) : base(nombre, fechaNacimiento, direccion)
	{
	}

	// c) Método "registro" para la clase "Cliente"
	public void Registro(int clienteID, string correoElectronico, string telefono)
	{
		this.clienteID = clienteID;
		this.CorreoElectronico = correoElectronico;
		this.telefono = telefono;
	}

	// f) Encapsulamiento en la propiedad "CorreoElectronico"
	public string CorreoElectronico
	{
		get { return correoElectronico; }
		set
		{
			if (!string.IsNullOrWhiteSpace(value) && value.Contains("@"))
			{
				correoElectronico = value;
			}
			else
			{
				throw new ArgumentException("Correo electrónico inválido");
			}
		}
	}
}

// b) Clase derivada "Empleado" que hereda de "Persona"
public class Empleado : Persona
{
	private int empleadoID;
	private string puesto;
	private double salario;

	public Empleado(string nombre, DateTime fechaNacimiento, string direccion) : base(nombre, fechaNacimiento, direccion)
	{
	}

	// c) Método "registro" para la clase "Empleado"
	public void Registro(int empleadoID, string puesto, double salario)
	{
		this.empleadoID = empleadoID;
		this.puesto = puesto;
		this.salario = salario;
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		// e) Implementación de las clases en el programa principal
		Cliente cliente = new Cliente("Juan Pérez", new DateTime(1990, 1, 1), "Calle 123");
		cliente.Registro(1, "juan.perez@email.com", "555-1234");

		Empleado empleado = new Empleado("Ana López", new DateTime(1985, 5, 15), "Avenida 456");
		empleado.Registro(100, "Gerente", 45000.0);
	}
}
