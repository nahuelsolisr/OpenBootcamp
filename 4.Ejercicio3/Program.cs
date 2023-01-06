// Recibo los datos por consola
Console.Write("Ingresa el ancho del rectángulo: ");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa el alto del rectángulo: ");
int alto = Convert.ToInt32(Console.ReadLine());
Console.Write("¿Quieres rellenar el rectángulo? (s/n): ");
char relleno = Convert.ToChar(Console.ReadLine());

// Dibujo el rectángulo
for (int i = 0; i < alto; i++)
{
    for (int j = 0; j < ancho; j++)
    {
        if (relleno == 's' || (i == 0 || i == alto - 1 || j == 0 || j == ancho - 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}

Console.ReadKey();