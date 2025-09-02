using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class LogTransaccione
{
    [Key]
    public int idLogTransacciones { get; set; }

    [StringLength(100)]
    public string? Modulo { get; set; }

    public int? idMovimiento { get; set; }

    [StringLength(100)]
    public string? NroFormulario { get; set; }

    public int? TipoMovimiento { get; set; }

    [StringLength(200)]
    public string? Accion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(200)]
    public string? Usuario { get; set; }

    [StringLength(200)]
    public string? Correo { get; set; }
}
