// See https://aka.ms/new-console-template for more information
using System.Data.Common;



Motos moto = new Motos();

moto.Id = 1;
moto.Marca = new Marcas();
moto.Modelo = "Szrr";
moto.Año = 2025;
moto.Cilindraje= 149.6f;
moto.Color = new Colores();

Console.WriteLine(moto.Modelo);
Console.WriteLine(moto.Id);
Console.WriteLine(moto.Cilindraje);


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

    public int Id;
    public Marcas? Marca { get ; set; } 
    public string? Modelo { get ; set; } 
    public bool? Encendida { get ; private set; } 
    public float? Cilindraje { get ; set; } 
    public Colores? Color { get ; set; }
    public int? Año { get ; set; }  



  
}

public class Deportivas : Motos
{

    public float? VelocidadMaxima { get ;  set; } 

}

