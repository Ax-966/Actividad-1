namespace Actividad_2;

public class PorNombre : Comparacion
{
    public bool sosIgual(Alumno a, Alumno b) { return a.getNombre().Equals(b.getNombre()); }
    public bool sosMenor(Alumno a, Alumno b) { return a.getNombre().CompareTo(b.getNombre()) < 0; }
    public bool sosMayor(Alumno a, Alumno b){  return a.getNombre().CompareTo(b.getNombre()) > 0; }    
}
