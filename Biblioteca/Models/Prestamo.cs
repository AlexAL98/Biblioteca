using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class Prestamo
{
    public int PrestamoId { get; set; }

    public int? LibroId { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FechaPrestamo { get; set; }

    public DateTime? FechaDevolucion { get; set; }

    public bool? Devuelto { get; set; }

    public virtual Libro? Libro { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
