using System;
using System.Collections;

namespace Actividad_1;

public class Numero : Comparable
{
    private int valor;
    private Comparable[] coleccionable;
    public Numero(int v) { this.valor = v; coleccionable = new Comparable[20];}
    public int getValor() => valor; 
    public override string ToString() => this.valor.ToString();
    public bool sosIgual(Comparable c) => valor == ((Numero)c).getValor() ? true : false; 
    public bool sosMenor(Comparable c) => valor < ((Numero)c).getValor() ? true : false; 
    public bool sosMayor(Comparable c) => valor > ((Numero)c).getValor() ? true : false; 
}
