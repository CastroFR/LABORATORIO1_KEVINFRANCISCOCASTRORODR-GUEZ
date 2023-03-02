using LABORATORIO1_KEVINFRANCISCOCASTRORODRÍGUEZ.Entidades;
using LABORATORIO1_KEVINFRANCISCOCASTRORODRÍGUEZ.Negocio;


Persona persona = new Persona();
ClsPersona clspersona = new ClsPersona();

Console.WriteLine("Dame tu nombre: ");
persona.Nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu edad: ");
persona.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dame tu tipo de sexo: ");
persona.Sexo = Console.ReadLine();

Console.WriteLine("Ingresa tu peso en Kg: ");
persona.Peso = float.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu Altura: ");
persona.Altura = float.Parse(Console.ReadLine());

clspersona.CalcularIMC(persona);
clspersona.EsMayorDeEdad(persona);

Console.WriteLine(clspersona.CalcularIMC(persona));
Console.WriteLine(clspersona.EsMayorDeEdad(persona));