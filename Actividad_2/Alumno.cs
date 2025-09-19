using System;
using System.Security;
using Actividad_2;

namespace Actividad_2;

public class Alumno : Persona
{
    private int legajo;
    private double promedio;
    private Comparacion estrategia;
    public Alumno(string n, int d, int l, double p) : base(n, d)
    {
        this.nombre = n; this.dni = d; this.legajo = l; this.promedio = p;
        estrategia = new PorNombre();
    }
    
    public override bool sosMenor(Comparable c)
    {
        Alumno otro = (Alumno)c;
        return estrategia.sosMenor(this, otro);
    }

    public override bool sosMayor(Comparable c)
    {
        Alumno otro = (Alumno)c;
        return estrategia.sosMayor(this, otro);
    }

    public override bool sosIgual(Comparable c)
    {
        Alumno otro = (Alumno)c;
        return estrategia.sosIgual(this, otro);
    }
    public int getLegajo() => legajo;
    public double getPromedio() => promedio;
//   public bool sosIgual(Alumno a, Alumno b){  return estrategia.sosIgual(a, b); }
//   public bool sosMayor(Alumno a, Alumno b){  return estrategia.sosMayor(a, b); }
//   public bool sosMenor(Alumno a, Alumno b){ return estrategia.sosMenor(a, b); }
    public void cambiarEstrategia( Comparacion nuevaEstrategia){ estrategia = nuevaEstrategia; }
    public override string ToString()
    {
        return $"Alumno: {nombre}, DNI: {dni}, Legajo: {legajo}, Promedio: {promedio}";
    }

    public string ToStringDni() => this.dni.ToString();

}
