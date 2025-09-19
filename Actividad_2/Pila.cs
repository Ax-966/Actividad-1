using System;
using System.Collections.Generic;
using Actividad_2;


namespace pila;

public class Pila : Coleccionable, Iterable
{
    private List<Comparable> datos = new List<Comparable>();

    public void apilar(Comparable elem) { this.datos.Add(elem); }
    public Comparable desapilar() { Comparable ultimo = this.datos[this.datos.Count - 1]; this.datos.RemoveAt(this.datos.Count - 1); return ultimo; }
    public Comparable tope() { return this.datos[this.datos.Count-1]; }
    public bool esVacia() { return this.datos.Count == 0; }

    //cuantos -> Devuelve la cantidad de elementos
    //comparables que tiene el coleccionable
    public int Cuantos() { return this.datos.Count; }

    //minimo -> Devuelve el elemento de menor valor
    //de la colección
    public Comparable Minimo()
    {
        if (this.esVacia()) { return null; }

        Comparable min = datos[0];
        foreach (Comparable c in datos)
            if (c.sosMenor(min)) min = c;
        return min;
    }

    //maximo -> Devuelve el elemento de mayor valor
    //de la colección.
    public Comparable Maximo()
    {
        if (this.esVacia()) { return null; }
        Comparable max = datos[0];
        foreach (Comparable c in datos)
            if (c.sosMayor(max)) max = c; return max;
    }

    //agregar(Comparable) -> Agrega el comparable recibido por 
    // parámetro a la colección que recibe el mensaje.
    public void Agregar(Comparable c) { this.datos.Add(c); }

    //contiene(Comparable) -> Devuelve verdadero si el
    //comparable recibido por parámetro está
    //incluido en la colección y falso en
    //caso contrario
    public bool Contiene(Comparable c)
    {
        bool encontrado = false; foreach (Comparable buscar in datos)
            if (buscar.sosIgual(c)) encontrado = true; return encontrado;
    }
    public List<Comparable> ComparablesPila() => datos;
    public Iterador crearIterador() => new IteradorDePilas(this); // Instanciamos el iterador hecho solamente para la pila.
}
