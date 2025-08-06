
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Vehiculos
{
    public class Coche : Vehiculo
    {
        public override void Describir()
        {
            Console.WriteLine($"Coche marca: {Marca}");
        }
    }
}
