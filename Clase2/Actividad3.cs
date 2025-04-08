using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Actividad3
    {
        static void Main1(string[] args)
        {
            Zorro zorrito = new Zorro();
            zorrito.especie = "Zorro";
            zorrito.colorDePelaje = "blanco";
            zorrito.habitat = "Desierto"; 
            zorrito.edad = 2;
            zorrito.genero = "Hembra";
            zorrito.esNocturno = true;
            zorrito.sonidoAnimal();
            zorrito.CazarDeNoche();

        }
        public class Animal
        {
            public string especie;
            public int edad;
            public string genero;
            public void alimentar()
            {
                Console.WriteLine("Se esta alimentando");
            }
            public void reproducir()
            {
                Console.WriteLine("Se estan reproduciendo");  
            }
            public void sonidoAnimal()
            {
                Console.WriteLine("Que sonido hace un: " + this.especie);
                string sonido = Console.ReadLine();
                Console.WriteLine("El " + this.especie + " hace " + sonido);
            }
        }
        public class Perro: Animal
        {
            public string raza;
            public bool vacunado;
            public void Jugar()
            {
                Console.WriteLine("El perro esta jugando");
            }
        }
        public class Zorro : Animal {

            public string habitat;
            public string colorDePelaje;
            public bool esNocturno; 
            public void CazarDeNoche()
            {
                if (this.esNocturno) {
                    Console.WriteLine("El " + this.especie + " esta cazando en el " + this.habitat + " por la noche"); 
                }
                else
                {
                    Console.WriteLine("El " + this.especie + " no es nocturno y no puede cazar");
                }
            }
        }
    }
}
