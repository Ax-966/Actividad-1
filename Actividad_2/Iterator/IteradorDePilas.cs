using System;
using System.Collections.Generic;
using pila;
namespace Actividad_2;


public class IteradorDePilas : Iterador
{
    private int cActual;
    private List<Comparable> comparablesPila;

    public IteradorDePilas(Pila pila)
    {
        comparablesPila = pila.ComparablesPila();
        cActual = comparablesPila.Count - 1;
    }

    public void Siguiente() => cActual--;
    public bool Fin() => cActual < 0;
    public Comparable Actual() => comparablesPila[cActual];
}
