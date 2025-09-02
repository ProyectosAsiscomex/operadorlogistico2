using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Almacene
{
    [Key]
    public int idalmacen { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? idciudad { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codigoalmacen { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NombreAlmacen { get; set; }

    public int? idcanal { get; set; }
}
