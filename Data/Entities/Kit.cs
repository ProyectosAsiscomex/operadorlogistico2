using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Kit")]
public partial class Kit
{
    [Key]
    public int idKit { get; set; }

    [StringLength(100)]
    public string? Tipo { get; set; }

    [StringLength(50)]
    public string? Prefijo { get; set; }

    [Column("do")]
    [StringLength(100)]
    public string? _do { get; set; }

    [StringLength(400)]
    public string? marca { get; set; }

    public double? numero { get; set; }

    public int? iddo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechauso { get; set; }

    [StringLength(10)]
    public string? idusuario { get; set; }

    [StringLength(50)]
    public string? nrodo { get; set; }
}
