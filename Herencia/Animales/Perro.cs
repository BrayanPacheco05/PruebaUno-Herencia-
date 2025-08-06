using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Animales
{
    public class Perro: Animal
    {
        public Perro(string nombre, int edad, string especie)
           : base(nombre, edad, especie) { }
        public void Sonido()
        {
            Console.WriteLine("Guau");
        }
    }
}
