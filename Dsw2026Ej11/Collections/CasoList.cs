using System;
using System.Collections.Generic;
using Dsw2026Ej11.Domain; 

namespace Dsw2026Ej11.Collections
{
    public class CasoList
    {
        // 1. Crear un campo que represente una lista de alumnos (List<>)
        private List<Alumno> alumnos = new List<Alumno>();

        // 2. Incluir un método para agregar alumnos a la lista
        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        // 3. Incluir un método para retornar la lista
        public List<Alumno> ObtenerLista()
        {
            return alumnos;
        }

        // 4. Incluir un método para buscar un alumno por nombre
        public Alumno BuscarAlumnoPorNombre(string nombre)
        {
            return alumnos.Find(a => a.Nombre == nombre)!;
        }

        // 5. Incluir un método para eliminar un alumno (debe recibir un alumno)
        public void EliminarAlumno(Alumno alumno)
        {
            alumnos.Remove(alumno);
        }

        // 6. Incluir un método para eliminar un alumno en una determinada posición de la lista
        public void EliminarAlumnoEnPosicion(int posicion)
        {
            if (posicion >= 0 && posicion < alumnos.Count)
            {
                alumnos.RemoveAt(posicion);
            }
        }
    }
}