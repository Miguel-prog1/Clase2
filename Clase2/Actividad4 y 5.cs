using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Actividad4
    {
        static void Main1(string[] args)
        {
            Biblioteca bi = new Biblioteca();
            bi.ubicacion = " lugano";
            bi.nombre = "bibliotega belgrano";
            bi.horaApertura = " 8:00";
            bi.agregarLibro();
            bi.agregarLibro();
            bi.BuscarLibro(); 
        }
        public class Libro
        {
            public string titulo;
            public string autor;
            public int año;
            public string genero;
            public void Abrir()
            {
                Console.WriteLine("El libro se esta abriendo");
            }
            public void Cerrar()
            {
                Console.WriteLine("El libro se esta cerrando");
            }
            public void Leer()
            {
                Console.WriteLine("Leyendo el libro"); 
            }
            public Libro (string titulo, string autor, int año, string genero)
            {
                this.titulo = titulo ; 
                this.autor = autor;
                this.año = año; 
                this.genero = genero ;
            }
        }
        public class Biblioteca
        {
            List<Libro> librero = new List<Libro>();
            public string nombre;
            public string ubicacion;
            public string horaApertura;
            public void agregarLibro()
            {
                Console.WriteLine("Porfavor ingrese el titulo del libro");
                string librotitulo = Console.ReadLine();
                Console.WriteLine("Ahora el autor del libro");
                string libroautor = Console.ReadLine();
                Console.WriteLine("Ahora el año");
                int libroAño = int.Parse(Console.ReadLine());
                Console.WriteLine("Y ahora el genero");
                string libroGenero = Console.ReadLine();
                Libro nuevolibro = new Libro(librotitulo, libroautor,libroAño,libroGenero);

                librero.Add(nuevolibro);
                Console.WriteLine("Ya se cargo el libro en el librero");
            }   
            public void BuscarLibro()
            {

                bool bandera = false;
                Console.WriteLine("Decime el titulo o el autor");
                string lupaTitle = Console.ReadLine();

                foreach (Libro libro in librero)
                {
                    if (libro.titulo == lupaTitle || libro.autor == lupaTitle)
                    {
                        Console.WriteLine(libro.titulo);
                        Console.WriteLine(libro.autor);
                        Console.WriteLine(libro.año);
                        Console.WriteLine(libro.genero);
                        bandera = true;
                    }
                }

                if (!bandera) {

                    Console.WriteLine("no encontramos  el libro");
                }

            }
            public void prestarLibro()
            {
                Console.WriteLine("Que libro queiere que le prestemos");
                string libroPrestado = Console.ReadLine();
                Console.WriteLine("Aqui teniene su libro, muchas gracias");
            }
            public void DevolverLibro()
            {
                Console.WriteLine("Que libro quiere Regresar");
                string LibroRegresar = Console.ReadLine();
                Console.WriteLine("Muchas gracias por devolver el libro");
            }
                
                
        }

    }
}
