using System;
using System.Collections.Generic;
using Dsw2026Ej11.Domain; 

namespace Dsw2026Ej11.Collections
{
    public class CasoDictionary
    {
        // 1. Crear un diccionario donde la clave sea el legajo (Id) y el valor el alumno
        private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

        // 2. Incluir un método para agregar un alumno al diccionario
        public void AgregarAlumno(Alumno alumno)
        {
            if (!alumnos.ContainsKey(alumno.Id))
            {
                alumnos.Add(alumno.Id, alumno);
            }
        }

        // 3. Incluir un método para buscar un alumno utilizando la clave
        public Alumno BuscarAlumno(int legajo)
        {
            if (alumnos.TryGetValue(legajo, out Alumno alumnoEncontrado))
            {
                return alumnoEncontrado;
            }
            return null!; 
        }

        // 4. Incluir un método para retornar el diccionario
        public Dictionary<int, Alumno> ObtenerDiccionario()
        {
            return alumnos;
        }

        // 5. Incluir un método para eliminar un alumno utilizando la clave
        public void EliminarAlumno(int legajo)
        {
            alumnos.Remove(legajo);
        }
    }
}