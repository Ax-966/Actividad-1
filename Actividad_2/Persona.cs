using System;
using System.Reflection.Metadata.Ecma335;
using Actividad_2;

namespace Actividad_2;

abstract public class Persona : Comparable
{
    protected string nombre;
    protected int dni;
    public Persona(string n, int d) { this.nombre = n; this.dni = d; }
    public string getNombre() => nombre;
    public int getDNI() => dni;

    // Comparable
    abstract public bool sosIgual(Comparable c);
    abstract public bool sosMenor(Comparable c);
    abstract public bool sosMayor(Comparable c);
}
