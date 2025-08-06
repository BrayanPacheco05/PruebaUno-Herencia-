using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HerenciaPolimorfismo.Usuarios
{

    public class Empleado : Persona
    {
        //Constructor
        public Empleado(string nombre, string apellidoPaterno, string apellidoMaterno)
        : base(nombre, apellidoPaterno, apellidoMaterno)
        {
       
        }

        public void FechaIngreso(DateTime fecha)
        {
            Console.WriteLine($"Fecha de ingreso: {fecha.ToShortDateString()}");
        }

    }

}
