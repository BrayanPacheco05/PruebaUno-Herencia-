using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Animales
{
    public class Animal
    {
        //Atributos
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }

        // Constructor
        public Animal(string nombre, int edad, string especie)
        {
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
        }

        //metodos 
        public void Caminar()
        {
            Console.WriteLine($"está caminando.");
        }

        public void Sonido()
        {
            Console.WriteLine($"Sonido Generico");
        }
    }
}
