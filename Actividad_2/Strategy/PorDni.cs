namespace Actividad_2;

public class PorDni : Comparacion
{
    public bool sosIgual(Alumno a, Alumno b) { return a.getDNI() == b.getDNI(); }
    public bool sosMayor(Alumno a, Alumno b) { return a.getDNI() < b.getDNI(); }
    public bool sosMenor(Alumno a, Alumno b){ return a.getDNI() > b.getDNI();  }
    
}
