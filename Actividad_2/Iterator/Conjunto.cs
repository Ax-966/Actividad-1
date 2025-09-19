using System;
using System.Collections.Generic;


namespace Actividad_2;

public class Conjunto : Coleccionable, Iterable
{
    private List<Comparable> elementos = new List<Comparable>();
  
    public void agregar(Comparable elemento) { if (!this.Pertenece(elemento)) { this.elementos.Add(elemento); } else { Console.WriteLine("El elemento ya existe"); } }
    //el cual devuelve true si el elemento recibido por parámetro ya
    //está dentro del conjunto, o false en caso contrario
    public bool Pertenece(Comparable elemento) { return this.Contiene(elemento); }

    //cuantos -> Devuelve la cantidad de elementos
    //comparables que tiene el coleccionable.
    public int Cuantos() { return this.elementos.Count; }

    //minimo -> Devuelve el elemento de menor valor
    //de la colección.
    public Comparable Minimo()
    {
        if (this.elementos.Count == 0) { return null!; }

        Comparable min = elementos[0];
        foreach (Comparable c in elementos)
            if (c.sosMenor(min)) min = c;
        return min;
    }

    //maximo -> Devuelve el elemento de mayor valor
    //de la colección.
    public Comparable Maximo()
    {
        if (this.elementos.Count == 0) { return null!; }

        Comparable max = elementos[0];
        foreach (Comparable c in elementos) if (c.sosMayor(max)) max = c; return max;
    }

    //agregar(Comparable) -> Agrega el comparable recibido por
    //parámetro a la colección que recibe el
    //mensaje.
    public void Agregar(Comparable c) { this.elementos.Add(c); }

    //contiene(Comparable) ->  Devuelve verdadero si el
    //comparable recibido por parámetro está
    //incluido en la colección y falso en
    //caso contrario.
    public bool Contiene(Comparable c)
    {
        foreach (Comparable buscar in elementos)
            if (buscar.sosIgual(c))
                return true;
        return false;
    }
    public List<Comparable> comparables() => elementos;
    public Iterador crearIterador() => new IteradorDeConjuntos(this); // Instanciamos el iterador hecho solamente para el conjunto.
}
