using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string? Titulo { get; set; }

    public int? AutorId { get; set; }

    public int? CategoriaId { get; set; }

    public int? AñoPublicacion { get; set; }

    public bool? Disponible { get; set; }

    public virtual Autore? Autor { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
