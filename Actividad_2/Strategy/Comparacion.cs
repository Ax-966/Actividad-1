using System;
namespace Actividad_2;

public interface Comparacion
{
    public bool sosIgual(Alumno a, Alumno b);
    public bool sosMayor(Alumno a, Alumno b);
    public bool sosMenor(Alumno a, Alumno b);
}
// Determina las acciones que si o si tienen que tener todos los estrategias, 
// pero no como llevarlas a cabo.