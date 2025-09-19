using System;
using System.Security;
using Actividad_1;

namespace Actividad_1;

public class Alumno : Persona
{
    private int legajo;
    private double promedio;
    public Alumno(string n, Numero d, int l, double p) : base(n, d)
    {
        this.nombre = n; this.dni = d; this.legajo = l; this.promedio = p;
    }
    public int getLegajo() => legajo;
    public double getPromedio() => promedio;
    // public override bool sosIgual(Comparable c) => this.dni.sosIgual(((Persona)c).getDNI());
    // public override bool sosMayor(Comparable c) => this.dni.sosMayor(((Persona)c).getDNI());
    // public override bool sosMenor(Comparable c) => this.dni.sosMenor(((Persona)c).getDNI());
    public override bool sosIgual(Comparable c)
    {
        Console.WriteLine("¿Desea comparar por legajo? --> Responda: si. Por defecto es por promedio");
        string res = Console.ReadLine();
        
        if (res.ToLower() == "si") return this.legajo == ((Numero)c).getValor() ? true : false;

        else return this.promedio == ((Numero)c).getValor() ? true : false;
    }
    public override bool sosMayor(Comparable c)
    {
        Console.WriteLine("¿Desea comparar por legajo? --> Responda: si. Por defecto es por promedio");
        string res = Console.ReadLine();
        
        if (res.ToLower() == "si") return this.legajo > ((Alumno)c).getLegajo() ? true : false;

        else return this.promedio > ((Alumno)c).getPromedio() ? true : false; 
    }
    public override bool sosMenor(Comparable c)
    {
        Console.WriteLine("¿Desea comparar por legajo? --> Responda: si. Por defecto es por promedio");

        string res = Console.ReadLine();


        if (res.ToLower() == "si") return this.legajo < ((Alumno)c).getLegajo() ? true : false;

        else return this.promedio < ((Alumno)c).getPromedio() ? true : false;
    }
    public override string ToString() => this.nombre.ToString();
    public string ToStringDni() => this.dni.ToString();

}
