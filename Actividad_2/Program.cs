using System;
using pila;
using cola;
namespace Actividad_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pila pila = new Pila();
            llenarAlumnos(pila);
            Console.WriteLine("\n--- Estrategia: Por Nombre ---");
            PorNombre porNombre = new PorNombre();
            cambiarEstrategia(pila, porNombre);
            informar(pila);
            Console.WriteLine("\n--- Estrategia: Por Legajo ---");
            PorLegajo porLegajo = new PorLegajo();
            cambiarEstrategia(pila, porLegajo);
            informar(pila);
            Console.WriteLine("\n--- Estrategia: Por Promedio ---");
            PorPromedio porPromedio = new PorPromedio();
            cambiarEstrategia(pila, porPromedio);
            informar(pila);
            Console.WriteLine("\n--- Estrategia: Por DNI ---");
            PorDni porDni = new PorDni();
            cambiarEstrategia(pila, porDni);
            informar(pila);

            //    Pila pila = new Pila();
            //    Cola cola = new Cola();
            //    Conjunto conjunto = new Conjunto();


            //    llenarAlumnos(cola);
            //    llenarAlumnos(c);
            //    imprimirElementos(pila);
            //    imprimirElementos(cola);
            //    imprimirElementos(conjunto);


            Console.ReadKey(true);
        }
        public static void llenar(Coleccionable coleccionable)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Ingrese un número al azar"); int a = int.Parse(Console.ReadLine());
                Comparable comparable = new Numero(a); coleccionable.Agregar(comparable);
            }
        }
        public static void informar(Coleccionable coleccionable)
        {
        //  Console.WriteLine(coleccionable.Cuantos());
            Console.WriteLine("Mínimo: " + coleccionable.Minimo());
            Console.WriteLine("Máximo: " + coleccionable.Maximo());
        //  Comparable comparable = new Numero(int.Parse(Console.ReadLine())); 
        //  if (coleccionable.Contiene(comparable)) { Console.WriteLine("El elemento leído esta en la colección"); }
        //  else { Console.WriteLine("El elemento leído no esta en la colección"); }

        }
        public static void llenarAlumnos(Coleccionable coleccionable)
        {
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno"); string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el dni del alumno"); int dni = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el legajo del alumno"); int legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el promedio del alumno"); double promedio = int.Parse(Console.ReadLine());

                Comparable comparable = new Alumno(nombre, dni, legajo, promedio);
                coleccionable.Agregar(comparable);
            }
        }
        public static void imprimirElementos(Coleccionable col)
        {
            Impresora impresora = new Impresora(); // Creamos una instancia de impresora.
            impresora.imprimir((Iterable)col);     // Casteamos la colección.

        }
        public static void cambiarEstrategia(Coleccionable coleccion, Comparacion estrategia)
        {
            Iterable iterable = (Iterable)coleccion; // Lo mismo de arriba, casteamos la colección.
            Iterador iterador = iterable.crearIterador(); // Para poder llamar al iterador propio de esa colección.

            while (!iterador.Fin()) // Va a entrar mientras el iterador no termine.
            {
                Alumno alumno = (Alumno)iterador.Actual(); // Casteamos a Alumno el valor del elemento actual,
                alumno.cambiarEstrategia(estrategia); // Para poder cambiar la estrategia del mismo.
                iterador.Siguiente(); // Pasamos al siguiente elemento.
            }
        }
    }
}