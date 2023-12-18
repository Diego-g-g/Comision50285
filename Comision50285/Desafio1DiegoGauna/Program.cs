// See https://aka.ms/new-console-template for more information
string nombre, apellido;
int edad = 0, dni = 0, num1 = 0, num2 = 0;
float altura;

//Ejercicio 1
Console.WriteLine("Hola");
Console.WriteLine("Por favor Ingrese su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Por favor Ingrese su Apellido");
apellido = Console.ReadLine();
Console.WriteLine("Por favor Ingrese su Documento");
dni = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor Ingrese su edad");
edad = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor Ingrese su altura");
altura = float.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Sus datos ingresados son:");
Console.WriteLine("Nmobre: " + nombre);
Console.WriteLine("Apellido: " + apellido);
Console.WriteLine("Documento: " + dni);
Console.WriteLine("Edad: " + edad);
Console.WriteLine("Altura: " + altura);
Console.WriteLine(" ");

//Ejercicio 2
Console.WriteLine("Suma de dos numeros");
Console.WriteLine("Ingrese el primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("El resultado es: " + (num1 + num2));
Console.WriteLine(" ");

//Ejercicio3
Console.WriteLine("ALIAS");
Console.WriteLine("Mi nombre es: " + nombre + " " + "\"Defton\""+ " " + apellido);


Console.ReadKey();

