using System;
using System.Collections.Generic;
using cola;
namespace Actividad_2;


public class IteradorDeColas : Iterador
{
    private int cActual;
    private List<Comparable> comparablesCola;

    public IteradorDeColas(Cola cola)
    {
        comparablesCola = cola.ComparablesCola();
        cActual = 0;
    }

    public void Siguiente() => cActual++;
    public bool Fin() => cActual >= comparablesCola.Count;
    public Comparable Actual() => comparablesCola[cActual];
}
