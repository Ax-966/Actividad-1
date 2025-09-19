using System;
using System.Collections.Generic;
using Actividad_2;


namespace cola;

public class Cola : Coleccionable, Iterable 
{
    private List<Comparable> elementos = new List<Comparable>();

    public void encolar(Comparable elem) { this.elementos.Add(elem); }
    public Comparable desencolar() { Comparable primero = this.elementos[0]; this.elementos.RemoveAt(0);  return primero; }
    public Comparable tope() { return this.elementos[0]; }
    public bool esVacia() { return this.elementos.Count == 0; }

    //cuantos -> Devuelve la cantidad de elementos
    //comparables que tiene el coleccionable
    public int Cuantos() { return this.elementos.Count; }

    //minimo -> Devuelve el elemento de menor valor
    //de la colección
    public Comparable Minimo()
    {
        if (this.esVacia()) { return null; }

        Comparable min = elementos[0];
        foreach (Comparable c in elementos) if (c.sosMenor(min)) min = c; return min;
    }

    //maximo -> Devuelve el elemento de mayor valor
    //de la colección
    public Comparable Maximo()
    {
        if (this.esVacia()) { return null; }

        Comparable max = elementos[0];
        foreach (Comparable c in elementos) if (c.sosMayor(max)) max = c; return max;
    }

    //agregar(Comparable) -> Agrega el comparable recibido por
    //parámetro a la colección que recibe el
    //mensaje
    public void Agregar(Comparable c) { this.elementos.Add(c); }

    //contiene(Comparable) -> Devuelve verdadero si el
    //comparable recibido por parámetro está
    //incluido en la colección y falso en
    //caso contrario
    public bool Contiene(Comparable c)
    {
        foreach (Comparable buscar in elementos)
            if (buscar.sosIgual(c))
                return true;
        return false;
    }
    public List<Comparable> ComparablesCola() => elementos;
    public Iterador crearIterador() => new IteradorDeColas(this); // Instanciamos el iterador hecho solamente para la cola.
}