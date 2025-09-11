using System;
using System.Reflection.Metadata.Ecma335;
using Actividad_1;

namespace Actividad_1;

abstract public class Persona : Comparable
{
    protected string nombre;
    protected Numero dni;
    public Persona(string n, Numero d) { this.nombre = n; this.dni = d; }
    public string getNombre() => nombre;
    public Numero getDNI() => dni;

    // Comparable
    abstract public bool sosIgual(Comparable c);
    abstract public bool sosMenor(Comparable c);
    abstract public bool sosMayor(Comparable c);
}
