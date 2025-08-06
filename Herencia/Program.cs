using Herencia.Animales;
using HerenciaPolimorfismo.Usuarios;
using HerenciaPolimorfismo.Vehiculos;
using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var empleado = new Empleado("Felix", "Pérez", "Gómez");

            empleado.MostrarInformacion(); 
            empleado.FechaIngreso(DateTime.Now);

            Perro perro = new Perro("Thor", 1, "Pastor Alemán");

            perro.Caminar();     
            perro.Sonido();       
            Console.ReadLine();

            List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Coche { Marca = "Toyota" },
            new Moto { Marca = "Yamaha" }
        };

            foreach (var v in vehiculos)
            {
                v.Describir(); 
            }
        }
    }
}