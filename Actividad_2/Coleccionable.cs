using System;
using System.ComponentModel;

namespace Actividad_2;

public interface Coleccionable
{
    //cuantos -> Devuelve la cantidad de elementos
    //comparables que tiene el coleccionable.
    public int Cuantos();

    //minimo -> Devuelve el elemento de menor valor
    //de la colección.
    public Comparable Minimo();

    //maximo -> Devuelve el elemento de mayor valor
    //de la colección.
    public Comparable Maximo();

    //agregar(Comparable) -> Agrega el comparable recibido por
    //parámetro a la colección que recibe el
    //mensaje.
    public void Agregar(Comparable c);

    //contiene(Comparable) ->  Devuelve verdadero si el
    //comparable recibido por parámetro está
    //incluido en la colección y falso en
    //caso contrario.
    public bool Contiene(Comparable c);
}
 