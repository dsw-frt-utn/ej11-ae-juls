using System;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests
{
    internal class Ejemplos
    {
        public static void EjemploList()
        {
            CasoList casoList = new CasoList();

            Alumno a1 = new Alumno(1, "Ana", 8.5);
            Alumno a2 = new Alumno(2, "Juan", 7.0);
            Alumno a3 = new Alumno(3, "Maria", 9.2);

            casoList.AgregarAlumno(a1);
            casoList.AgregarAlumno(a2);
            casoList.AgregarAlumno(a3);

            Console.WriteLine("--- LISTA DE ALUMNOS ---");
            foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.ToString());

            Console.WriteLine("\n--- BUSCANDO A 'Juan' ---");
            Alumno encontrado = casoList.BuscarAlumnoPorNombre("Juan");
            Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

            Console.WriteLine("\n--- BUSCANDO A 'Pedro' ---");
            Alumno noEncontrado = casoList.BuscarAlumnoPorNombre("Pedro");
            Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

            Console.WriteLine("\n--- ELIMINANDO A 'Ana' ---");
            casoList.EliminarAlumno(a1);
            foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.ToString());

            Console.WriteLine("\n--- ELIMINANDO EL PRIMER ELEMENTO ---");
            casoList.EliminarAlumnoEnPosicion(0);
            foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.ToString());
        }

        public static void EjemploDictionary()
        {
            CasoDictionary casoDict = new CasoDictionary();

            Alumno a1 = new Alumno(10, "Carlos", 6.5);
            Alumno a2 = new Alumno(20, "Lucia", 8.0);
            Alumno a3 = new Alumno(30, "Marcos", 7.5);

            casoDict.AgregarAlumno(a1);
            casoDict.AgregarAlumno(a2);
            casoDict.AgregarAlumno(a3);

            Console.WriteLine("\n--- DICCIONARIO DE ALUMNOS ---");
            foreach (var a in casoDict.ObtenerDiccionario().Values) Console.WriteLine(a.ToString());

            Console.WriteLine("\n--- BUSCANDO LEGAJO 20 ---");
            Alumno encontrado = casoDict.BuscarAlumno(20);
            Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

            Console.WriteLine("\n--- BUSCANDO LEGAJO 99 ---");
            Alumno noEncontrado = casoDict.BuscarAlumno(99);
            Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

            Console.WriteLine("\n--- ELIMINANDO LEGAJO 10 ---");
            casoDict.EliminarAlumno(10);
            foreach (var a in casoDict.ObtenerDiccionario().Values) Console.WriteLine(a.ToString());
        }

        public static void EjemploLinq()
        {
            CasoLinq casoLinq = new CasoLinq();

            casoLinq.AgregarLibro(new Libro(10, "El Aleph", 1200m));
            casoLinq.AgregarLibro(new Libro(20, "Rayuela", 2500m));
            casoLinq.AgregarLibro(new Libro(16, "Ficciones", 1800m));

            Console.WriteLine("\n--- PRUEBAS DE LINQ ---");

            Console.WriteLine($"1. Primer libro: {casoLinq.GetPrimero()?.Titulo}");
            Console.WriteLine($"2. Último libro: {casoLinq.GetUltimo()?.Titulo}");
            Console.WriteLine($"3. Suma total de precios: {casoLinq.GetTotalPrecios()}");
            Console.WriteLine($"4. Promedio de precios: {casoLinq.GetPromedioPrecios()}");

            Console.WriteLine("5. Libros con Id > 15:");
            foreach (var l in casoLinq.GetListById()) Console.WriteLine($"   - {l.Titulo}");

            Console.WriteLine("6. Lista de strings (Título y Moneda):");
            foreach (var s in casoLinq.GetLibros()) Console.WriteLine($"   - {s}");

            Console.WriteLine($"7. Libro más caro: {casoLinq.GetMayorPrecio()?.Titulo}");
            Console.WriteLine($"8. Libro más barato: {casoLinq.GetMenorPrecio()?.Titulo}");

            Console.WriteLine("9. Libros con precio mayor al promedio:");
            foreach (var l in casoLinq.GetMayorPromedio()) Console.WriteLine($"   - {l.Titulo}");

            Console.WriteLine("10. Libros ordenados (Z-A):");
            foreach (var l in casoLinq.GetOrdenadosDescendente()) Console.WriteLine($"   - {l.Titulo}");
        }
    }
}