using System;
using Actividad_1;
using cola;
using pila;

namespace Actividad_1;

public class ColeccionMultiple : Coleccionable
{
    private Pila pila;
    private Cola cola;

    public ColeccionMultiple(Pila p, Cola c) { this.pila = p; this.cola = c; }

    // Devuelve la cantidad de elementos de ambos coleccionables.
    public int Cuantos() =>  this.pila.Cuantos() + this.cola.Cuantos(); 


    public Comparable Minimo()
    {
        Comparable minPila = pila.Minimo();
        Comparable minCola = cola.Minimo();

        if (minPila == null && minCola == null) { return null; }
        else if (minPila == null) { return minCola; } 
        else if (minCola == null){ return minPila; }
        else{ if (minPila.sosMenor(minCola)){ return minPila;}  else { return minCola;}}
    }

    public Comparable Maximo()
    {
        Comparable maxPila = pila.Maximo();
        Comparable maxCola = cola.Maximo();

        if (maxPila == null && maxCola == null) { return null; }
        else if (maxPila == null) { return maxCola; } 
        else if (maxCola == null){ return maxPila; }
        else{ if (maxPila.sosMayor(maxCola)){ return maxPila;}  else { return maxCola;}}
    }

    //agregar() no hace nada.
    public void Agregar(Comparable c) { }
    
    //contiene(Comparable). Devuelve verdadero si el
    //comparable recibido por parámetro está
    //incluido en alguna de las dos colecciones o en ambas y falso en caso contrario.
    public bool Contiene(Comparable c)
    {
        if (pila.Contiene(c)) { return true; }
        else if (cola.Contiene(c)) { return true; }
        else if (pila.Contiene(c) && cola.Contiene(c)) { return true; }
        else { return false; }
    }
}
