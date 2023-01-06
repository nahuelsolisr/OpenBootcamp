// Declaración de variables
int numero;
int contadorPositivos = 0;
int contadorNegativos = 0;
bool seguirIngresando = true;

// Recibimos números por consola 
do
{
    Console.Write("Ingresa un número (o ingresa 0 para terminar): ");
    numero = Convert.ToInt32(Console.ReadLine());

    // Si se ingresó el número 0, termina.
    if (numero == 0)
    {
        seguirIngresando = false;
    }
    else
    {
        // para comprobar si el numero es negativo o positivo
        if (numero >= 0)
        {
            contadorPositivos++;
        }
        else
        {
            contadorNegativos++;
        }
    }
} while (seguirIngresando);

// Presentamos el contador para cada tipo de número
Console.WriteLine("Contadores:");
Console.WriteLine($"  Números positivos: {contadorPositivos}");
Console.WriteLine($"  Números negativos: {contadorNegativos}");


Console.ReadKey();