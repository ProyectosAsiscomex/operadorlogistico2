using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TransportadorNacional")]
public partial class TransportadorNacional
{
    [Key]
    public int idtransportadornacional { get; set; }

    [StringLength(50)]
    public string? tipodocumento { get; set; }

    [StringLength(20)]
    public string? identificacion { get; set; }

    [StringLength(1)]
    public string? dv { get; set; }

    [StringLength(100)]
    public string? nombre { get; set; }

    [StringLength(100)]
    public string? ciudad { get; set; }

    [StringLength(50)]
    public string? telefono { get; set; }

    [StringLength(50)]
    public string? fax { get; set; }

    [StringLength(100)]
    public string? correo { get; set; }
}
