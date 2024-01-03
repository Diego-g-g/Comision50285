
Console.WriteLine("BIENVENIDOS A LA UNIVERSIDAD CODERHOUSE!!!!!");
Console.WriteLine(" ");
Console.WriteLine("EL MEJOR LUGAR PARA ESTUDIAR DEL MUNDO");
Console.WriteLine(" ");
Console.WriteLine("INGRESE LA COMISION");

String comision = Console.ReadLine();
int nota = 0;

switch (comision)
{
	case "A":
        Console.WriteLine("Turno Mañana");
        break;
    case "B":
        Console.WriteLine("Turno Tarde");
        break;
    case "C":
        Console.WriteLine("Turno Noche");
        break;

    default:
        Console.WriteLine("Sin turno fijo");
		break;
}


Console.WriteLine("BIENVENIDOS A LA UNIVERSIDAD CODERHOUSE!!!!!");
Console.WriteLine(" ");
Console.WriteLine("EL MEJOR LUGAR PARA ESTUDIAR DEL MUNDO");
Console.WriteLine(" ");
Console.WriteLine("INGRESE LA NOTA DEL ALUMNO");

nota = Convert.ToInt32(Console.ReadLine());

if ( nota < 4)
{
    Console.WriteLine("Recursa la materia");

}else if(nota >= 4 && nota <= 7)
{
    Console.WriteLine("Aprobó cursada");
}
else
{
    Console.WriteLine("Promociona la materia");
}

Console.ReadKey();