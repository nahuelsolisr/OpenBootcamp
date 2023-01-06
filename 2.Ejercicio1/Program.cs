
// Declaración de variables
string nombre = "Rodrigo";
string apellido = "Solis";
int edad = 22;
bool programa = true;

// Generación del mensaje

string mensaje = $"Hola, mi nombre es {nombre} {apellido} y tengo {edad} años.";

if (programa)
{
    mensaje += " Además, sé programar.";
}
else
{
    mensaje += " No sé programar.";
}

// Imprimimos el mensaje
Console.WriteLine(mensaje);




