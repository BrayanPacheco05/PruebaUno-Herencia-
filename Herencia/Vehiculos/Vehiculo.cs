using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Vehiculos
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public virtual void Describir()
        {
            Console.WriteLine($"Vehículo marca: {Marca}");
        }
    }
}
