using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class EncargadosEmpresa
{
    [Key]
    public int idencargado { get; set; }

    public int? idempresa { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Cargo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Telefonodirecto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? celular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ContactoAbreviado { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pais { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Correo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }
}
