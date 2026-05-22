using System;
using System.Collections.Generic;
using System.Linq;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections
{
    public class CasoLinq
    {
        public List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public Libro GetPrimero()
        {
            return libros.FirstOrDefault()!;
        }

        public Libro GetUltimo()
        {
            return libros.LastOrDefault()!;
        }

        public decimal GetTotalPrecios()
        {
            return libros.Sum(l => l.Precio);
        }

        public decimal GetPromedioPrecios()
        {
            if (libros.Count == 0) return 0m;
            return libros.Average(l => l.Precio);
        }

        public List<Libro> GetListById()
        {
            return libros.Where(l => l.Id > 15).ToList();
        }

        public List<string> GetLibros()
        {
            return libros.Select(l => $"{l.Titulo} - {l.Precio.ToString("C")}").ToList();
        }

        public Libro GetMayorPrecio()
        {
            return libros.OrderByDescending(l => l.Precio).FirstOrDefault()!;
        }

        public Libro GetMenorPrecio()
        {
            return libros.OrderBy(l => l.Precio).FirstOrDefault()!;
        }

        public List<Libro> GetMayorPromedio()
        {
            decimal promedio = GetPromedioPrecios();
            return libros.Where(l => l.Precio > promedio).ToList();
        }

        public List<Libro> GetOrdenadosDescendente()
        {
            return libros.OrderByDescending(l => l.Titulo).ToList();
        }
    }
}