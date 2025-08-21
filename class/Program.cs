// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Hello, World!");

Motos moto = new Motos();

moto.id = 1;
moto.Marca = new Marcas();
moto.Modelo = "Szrr";
moto.Año = 2025;
moto.Cilindraje= 149.6f;
moto.Color = new Colores();




public class Colores
{

 public int Id;
 public string? Nombre { get ;  set; } 

}

public class Marcas
{
    
     public int Id;
 public string? Nombre { get ;  set; } 

}
public class Motos
{

    public int id;
    public Marcas? Marca { get ; set; } 
    public string? Modelo { get ; set; } 
    public bool? Encendida { get ; private set; } 
    public float? Cilindraje { get ; set; } 
    public Colores? Color { get ; set; }
    public int? Año { get ; set; }  



    public Motos()
    {
    }
}

public class Deportivas : Motos
{

    public float? VelocidadMaxima { get ; private set; } 

}

