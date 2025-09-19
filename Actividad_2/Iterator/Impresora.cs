using System;
namespace Actividad_2;

public class Impresora
{
    public void imprimir(Iterable coleccion) // Nos permite poder imprimir cualquier tipo de estructura.
    {
        Iterador iterador = coleccion.crearIterador();
        Console.WriteLine("Imprimiendo colección:");
        while (!iterador.Fin())
        {
            Console.WriteLine(iterador.Actual());
            iterador.Siguiente();
        }

    }
}
