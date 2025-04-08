using System;
namespace Actividad1
{
    internal class Actividad1
    {
        static void Main1(string[] args) 
        {
        
            Autobus autobus = new Autobus();
            autobus.ruedas = 4;
            autobus.capacidadDePasajero = 50;
            autobus.numeroDePuertas = 3;
            autobus.numeroDeAsientos = 31;
            autobus.CargaDePasajeros();
            autobus.DescargaDePasajeros();

        }
         
    }
    public class Vehiculo
    {
        public int ruedas;
        public int capacidadDePasajero;
        public int numeroDePuertas;
        public int numeroDeAsientos;

        public void CargaDePasajeros()
        {
            Console.WriteLine("Se subio un pasajero");


        }
        public void DescargaDePasajeros()
        {
            Console.WriteLine("Se bajo un pasajero");
        }
    }
    public class Autobus : Vehiculo
    {

    }
}