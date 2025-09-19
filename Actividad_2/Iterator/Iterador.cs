using System;
namespace Actividad_2;

public interface Iterador
{
    public void Siguiente();
    public bool Fin();
    public Comparable Actual();
}
// Determina las acciones que si o si tienen que tener todos los iteradores, 
// pero no como llevarlas a cabo.