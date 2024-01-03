
int pass = 12345678;
string perfil = "A";

Console.WriteLine("Bienvenido");
Console.WriteLine("Ingrese su contrseña");

if (Convert.ToInt32(Console.ReadLine()) == pass)
{
    switch (perfil)
    {
        case "A":
            Console.WriteLine("Bienvenido Administrador");
            break;
        case "B":
            Console.WriteLine("Bienvenido Usuario");
            break;
        default:
            Console.WriteLine("Sin perfil definido");
            break;
    }
}
else
{
    Console.WriteLine("Acceso denegado. Ingrese nuvamente la clave");
    
    if (Convert.ToInt32(Console.ReadLine()) == pass)
    {
        switch (perfil)
        {
            case "A":
                Console.WriteLine("Bienvenido Administrador");
                break;
            case "B":
                Console.WriteLine("Bienvenido Usuario");
                break;
            default:
                Console.WriteLine("Sin perfil definido");
                break;
        }

    }
    else
    {
        Console.WriteLine("Debe reiniciar el sistema");
    }
}
Console.ReadKey();
