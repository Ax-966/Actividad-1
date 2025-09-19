using System;
using System.Collections.Generic;
using cola;
namespace Actividad_2;


public class IteradorDeConjuntos : Iterador
{
    private List<Comparable> comparables;
    private int cActual;
    

    public IteradorDeConjuntos(Conjunto conjunto) { comparables = conjunto.comparables(); cActual = 0; }


    public Comparable Actual() => comparables[cActual];
    public void Siguiente() { cActual++; }
    public bool Fin() => cActual >= comparables.Count;
    
}