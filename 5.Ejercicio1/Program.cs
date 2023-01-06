Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingresa tu email: ");
string email = Console.ReadLine();
Console.Write("¿Tienes un cupón de descuento? (s/n): ");
char cupon = Convert.ToChar(Console.ReadLine());

// Precio 
decimal precioSinDescuento = 100.0m;
decimal precioConDescuento = 100.0m;

// Si el cliente tiene un cupón de descuento, aplicamos el descuento de 10%
if (cupon == 's')
{
    Console.WriteLine($"Hola {nombre}.");
    precioConDescuento = precioSinDescuento * 0.9m;
    Console.WriteLine($"El precio del producto es: {precioConDescuento}.");

}
else
{
    Console.WriteLine($"Hola {nombre}.");
    Console.WriteLine($"El precio del producto es: {precioSinDescuento}.");

}

