namespace Actividad_2;

    public class PorPromedio : Comparacion
    {
    public bool sosIgual(Alumno a, Alumno b) { return a.getPromedio() == b.getPromedio(); }
    public bool sosMayor(Alumno a, Alumno b) { return a.getPromedio() > b.getPromedio(); }
    public bool sosMenor(Alumno a, Alumno b){ return a.getPromedio() < b.getPromedio();  }
 
    
    }
