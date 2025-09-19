using System;
namespace Actividad_2;

public interface Iterable
{
    public Iterador crearIterador(); // Nos va a servir para instanciar el iterador en la 
                                     // colección que lo necesitemos.
}