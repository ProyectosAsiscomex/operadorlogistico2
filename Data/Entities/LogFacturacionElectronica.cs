using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("LogFacturacionElectronica")]
public partial class LogFacturacionElectronica
{
    [Key]
    public int idLogFacturacionElectronica { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Unicode(false)]
    public string? Contenido { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Do { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroFactura { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FechaFactura { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? total { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? terceros { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? propios { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? respuesta { get; set; }
}
