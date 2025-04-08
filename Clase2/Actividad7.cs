using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Actividad7
    {
        static void Main(string[] args)
        {
            Departamento de = new Departamento();
            de.nombre = "merca";
            de.cantEmpleados = 23;
            de.agregarEmpleados();
            de.verEmpleados();
            Console.WriteLine("Dame tu salario");
            de.calcSalario(double.Parse(Console.ReadLine())); 

        }

        public class Empleado
        {
            public string nombre;
            public string apellido;
            public int edad;
            public float salario;
            public string rol;

            public void trabajar()
            {
                Console.WriteLine("esta trabajando");
            
            }

        }

        public class Departamento
        {
            public string nombre;
            public int cantEmpleados;
            List<Empleado> lista = new List<Empleado>();
            public void agregarEmpleados()
            {
                Console.WriteLine("Ingrese el nombre");
                
                string empNombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido");
                string empApellido = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                int empEdad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el salario");
                float empSalario = float.Parse(Console.ReadLine());
                Empleado emp = new Empleado { nombre = empNombre, apellido = empApellido, edad = empEdad, salario = empSalario };

                lista.Add(emp);
            }
            public void asignarRol()
            {
                Console.WriteLine("Ingrese algun rol");
                string rolsito = Console.ReadLine();
                foreach (Empleado e in lista)
                {
                    e.rol = rolsito; 

                }
            }

            public void verEmpleados()
            {
                foreach (Empleado e in lista)
                {
                    Console.WriteLine(e.nombre);
                    Console.WriteLine(e.apellido);
                    Console.WriteLine(e.edad);
                    Console.WriteLine(e.salario);
                    Console.WriteLine(e.rol); 
                }
            }
            public void calcSalario(double salario)
            {
                double porcentaje = salario * 0.30;
                salario = salario - porcentaje; 
                Console.WriteLine("Vamos a restar 30% de tu salario por temas de nomina y ese 30% va hacer un total de: " + porcentaje);
                Console.WriteLine("Ahora tu salio es de: " + salario);
            }

        }
        public class Rol
        {
            public string nombreRol;

        }

    }
}
