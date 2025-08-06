using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo.Banco
{
    public class CuentaBancaria
    {
        public string NombreTitular { get; set; }
        public decimal Saldo { get; protected set; }

        public virtual void Depositar(decimal monto)
        {
            Saldo += monto;
        }

        public virtual void Retirar(decimal monto)
        {
            Saldo -= monto;
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo actual: {Saldo:C}");
        }
    }
}
