Console.WriteLine("Indicame un número");
int numero = Convert.ToInt32(Console.ReadLine());
int tabla = 1;

while (tabla <= 10)
{
    int resultado = numero * tabla;
    Console.WriteLine(numero + " x " + tabla + "=" + resultado);
    tabla++;
}

Console.ReadKey();