int numero = 20;
if (numero >= 18)
{
    Console.WriteLine("El número es mayor o igual a 18.");
}
else
{
    Console.WriteLine("El número es menor a 18.");
}

// Verificamos si un char es 'a'
char letra = 'a';
if (letra == 'a')
{
    Console.WriteLine("El char es 'a'.");
}
else
{
    Console.WriteLine("El char no es 'a'.");
}

// Verificamos si se cumplen dos condiciones a la vez
bool condicion1 = true;
bool condicion2 = true;
if (condicion1 && condicion2)
{
    Console.WriteLine("Ambas condiciones se cumplen.");
}
else
{
    Console.WriteLine("No se cumplen ambas condiciones.");
}

// Verificamos si se cumple una de dos condiciones a la vez
condicion1 = true;
condicion2 = false;
if (condicion1 || condicion2)
{
    Console.WriteLine("Se cumple al menos una de las dos condiciones.");
}
else
{
    Console.WriteLine("No se cumple ninguna de las dos condiciones.");
}

Console.ReadKey();