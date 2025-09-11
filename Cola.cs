using System;
using Actividad_1;

namespace cola;

public class Cola : Coleccionable
{
    private List<Comparable> elementos = new List<Comparable>();

    public void encolar(Comparable elem) { this.elementos.Add(elem); }
    public Comparable desencolar() { Comparable ultimo = this.elementos[-1]; this.elementos.RemoveAt(-1); return ultimo; }
    public Comparable tope() { return this.elementos[-1]; }
    public bool esVacia() { return this.elementos.Count == 0; }

    //cuantos -> Devuelve la cantidad de elementos
    //comparables que tiene el coleccionable
    public int Cuantos() { return this.elementos.Count; }

    //minimo -> Devuelve el elemento de menor valor
    //de la colección
    public Comparable Minimo()
    {
        if(this.esVacia()){ return null; }

        Comparable min = elementos[0];
        foreach (Comparable c in elementos) if (c.sosMenor(min)) min = c; return min;
    }

    //maximo -> Devuelve el elemento de mayor valor
    //de la colección
    public Comparable Maximo()
    {
        if(this.esVacia()){ return null; }
        
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
}