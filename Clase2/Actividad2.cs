using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Actividad2
    {
        static void Main1(string[] args)
        {
            Auto auto1= new Auto();
            auto1.modelo = "250 GTO";
            auto1.marca = "ferrari";
            auto1.año = 1961;
            auto1.numeroDeSerie = "3527 gt";
            auto1.Arrancar();
            auto1.Frenar();
            auto1.Acelerar();
            auto1.Retrocediendo();
        }
        public class Vehiculo
        {
            public string modelo;
            public string marca;
            public int año;
            public string numeroDeSerie;


            public void Arrancar()
            {
                Console.WriteLine("Esta arrancando");
            }
            public void Frenar()
            {
                Console.WriteLine("Esta frenando");
            }
            public void Retrocediendo()
            {
                Console.WriteLine("Esta retrocediendo");
            }
            public void Acelerar()
            {
                Console.WriteLine("Esta acelerando");
            }
        }
        public class Auto : Vehiculo
        {

        }
        public class Colectivo : Vehiculo
        {

        }
        public class Camion : Vehiculo
        {

        }
    }
}
