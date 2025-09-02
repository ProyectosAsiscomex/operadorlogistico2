using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Comunicacion")]
public partial class Comunicacion
{
    [Key]
    public int idcomunicacion { get; set; }

    public int? idempresa { get; set; }

    [StringLength(500)]
    public string? bd { get; set; }

    [StringLength(500)]
    public string? servidor { get; set; }

    [StringLength(500)]
    public string? usuario { get; set; }

    [StringLength(500)]
    public string? opassword { get; set; }

    public bool? actualizar { get; set; }
}
