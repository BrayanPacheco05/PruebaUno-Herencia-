using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Usuarios
{
    public class Persona
    {
        // Atributos
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        //constructor
        public Persona(string nombre, string apellidoPaterno, string apellidoMaterno) 
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"");
        }
    }


}
