using System;
using pila;
using cola;
namespace Actividad_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            //llenar(pila);
            //informar(pila);
            //informar(cola);
            informar(multiple);
            Console.ReadKey(true);
        }
        public static void llenar(Coleccionable coleccionable)
        {
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Ingrese un número al azar"); int a = int.Parse(Console.ReadLine());
                Comparable comparable = new Numero(a); coleccionable.Agregar(comparable);
            }
        }
        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine(coleccionable.Cuantos());
            Console.WriteLine(coleccionable.Minimo());
            Console.WriteLine(coleccionable.Maximo());
        //  Comparable comparable = new Numero(int.Parse(Console.ReadLine())); 
        //  if (coleccionable.Contiene(comparable)) { Console.WriteLine("El elemento leído esta en la colección"); }
        //  else { Console.WriteLine("El elemento leído no esta en la colección"); }

        }
        public static void llenarAlumnos(Coleccionable coleccionable)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno"); string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el dni del alumno"); Numero dni = new Numero(int.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese el legajo del alumno"); int legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el promedio del alumno"); double promedio = int.Parse(Console.ReadLine());

                Comparable comparable = new Alumno(nombre, dni, legajo, promedio);
                coleccionable.Agregar(comparable);
            }
        }
    }
}