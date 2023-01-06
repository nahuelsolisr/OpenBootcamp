

Cliente NuevoCliente = new Cliente("Rodrigo Solis", "1234567890", "Calle Falsa 123", "ro@example.com", true);

Console.WriteLine("Información del cliente:");
Console.WriteLine($"  Nombre completo: {NuevoCliente.NombreCompleto}");
Console.WriteLine($"  Teléfono: {NuevoCliente.Telefono}");
Console.WriteLine($"  Dirección: {NuevoCliente.Direccion}");
Console.WriteLine($"  Email: {NuevoCliente.Email}");
Console.WriteLine($"  ¿Es nuevo cliente?: {NuevoCliente.EsNuevoCliente}");
Console.ReadKey();

public struct Cliente
{

    public Cliente(string a, string b, string c, string d, bool e)
    {
        NombreCompleto = a;
        Telefono = b;
        Direccion = c;
        Email = d;
        EsNuevoCliente = e;

    }

    public string NombreCompleto { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool EsNuevoCliente { get; set; }

    
}










