// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Tipos
{
    public int Id;
    public string? Descripcion;
    public List<Balones>? Balones;
}

public class Marcas
{
    public int Id;
    public string? Nombre;
    public List<Balones>? Balones;
}

public class Bodegas
{
    public int Id;
    public string? Nombre;
    public string? Direccion;
    public int Capacidad;
    public List<Balones>? balones;
}

public class Balones
{
    public int Id;
    public string? Nombre;
    public decimal Peso;
    public bool Disponible;
    public string? Color;
    public double Precio;
    public Tipos? Tipo;
    public Marcas? Marca;
    public Bodegas? Bodega;
}

