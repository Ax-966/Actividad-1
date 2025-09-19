namespace Actividad_2;

    public class PorLegajo : Comparacion
    {
    public bool sosIgual(Alumno a, Alumno b) { return a.getLegajo() == b.getLegajo(); }
    public bool sosMayor(Alumno a, Alumno b) { return a.getLegajo() > b.getLegajo(); }
    public bool sosMenor(Alumno a, Alumno b){ return a.getLegajo() < b.getLegajo();  }
 
    
    }