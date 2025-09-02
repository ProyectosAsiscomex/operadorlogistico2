using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Imputacione
{
    [Key]
    public int idimputa { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? centro { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cuenta { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? comprobant { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? mes { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? dia { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ano { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? documento { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? documentor { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? nit { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string? detalle { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? tipo { get; set; }

    [Column(TypeName = "decimal(16, 2)")]
    public decimal? valor { get; set; }

    [Column(TypeName = "decimal(16, 2)")]
    public decimal? base_plazo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? item { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? tas_ret { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? tas_retiva { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? unic_id_pr { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ciud { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? nomb { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? nit_prov { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? doc_numero { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? proyec { get; set; }
}
