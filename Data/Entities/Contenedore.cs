using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Contenedore
{
    [Key]
    public int idContenedor { get; set; }

    [StringLength(200)]
    public string? numero { get; set; }

    [StringLength(500)]
    public string? transportador { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadespacho { get; set; }

    [StringLength(200)]
    public string? comodato { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechalibre { get; set; }

    [StringLength(500)]
    public string? regresaa { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadevolucion { get; set; }

    [StringLength(50)]
    public string? tipo { get; set; }
}
