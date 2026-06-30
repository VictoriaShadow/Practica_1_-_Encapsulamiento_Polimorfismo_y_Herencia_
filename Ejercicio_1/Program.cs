using System.Runtime.CompilerServices;
using AutoDrive;
List <Vehiculo> vehiculos = new List <Vehiculo> ();

vehiculos.Add (new AutoElectrico{Marca = "BYD", Autonomia = 500});
vehiculos.Add (new AutoElectrico{Marca = "Renault", Autonomia = 280});
vehiculos.Add (new Camioneta{Marca = "Toyota", Traccion4x4 = true});
vehiculos.Add (new Camioneta{Marca = "Volkswagen", Traccion4x4 = false});

foreach (var Vehiculo in vehiculos)
{
    string mensaje = Vehiculo.Arrancar();
    Console.WriteLine(mensaje);
}
Console.ReadLine();
