Console.WriteLine("Seleccione un lenguaje de programación");
Console.WriteLine("a. C# ");
Console.WriteLine("b. JAVA ");
Console.WriteLine("c. C++ ");

string opcion = Console.ReadLine();

switch (opcion)
{
    case "a":
        Console.WriteLine("ha saleccionado la opcion de C# ¡Hola, mundo!");
        break;

    case "b":
        Console.WriteLine("ha saleccionado la opcion de JAVA");
        break;

    case "c":
        Console.WriteLine("ha saleccionado la opcion de C++");
        break;

    default:
        Console.WriteLine("opcion no valida");
        break;


}

Console.ReadKey();