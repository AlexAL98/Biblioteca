using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string? NombreCategoria { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
