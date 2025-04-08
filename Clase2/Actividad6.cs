using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Actividad_5
    {
        static void Main1(string[] args)
        {
            Cajero cajerito = new Cajero();
            cajerito.ubicacion = "lugano";
            cajerito.numeroSerie = " 111122222333";
            cajerito.saldo = 200;
            cajerito.retirarDinero(); 
            cajerito.VerSaldo();
            cajerito.depositarDinero(); 
        }
    
        public class Cajero
        {
            public string ubicacion;
            public string numeroSerie;
            public int saldo;
        
            public void retirarDinero()
            {
                Console.WriteLine("Cuanto dinero quiere retirar"); 
                int retiro = int.Parse(Console.ReadLine());
                if (saldo > 0 && retiro <= saldo)
                {
                    this.saldo = this.saldo - retiro;
                }
                else
                {
                    Console.WriteLine("No puede retirar esa cantidad porque no teiene saldo");
                }
            }
            public void VerSaldo()
            {
                Console.WriteLine(this.saldo);
            }
            public void depositarDinero()
            {
                Console.WriteLine("Cuanto dinero quiere depositar");
                int dinero = int.Parse(Console.ReadLine());
                this.saldo = dinero + saldo;
                VerSaldo();
            }
        
        }

    }
}
