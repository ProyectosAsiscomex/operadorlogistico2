using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Liquidacion_LeonisaConcepto
{
    [Key]
    public int idleonisaconcepto { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cuentaleonisa { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? conceptoleonisa { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tipo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? division { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? depto { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cc { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ln { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? reg { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? lv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? camp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tercero { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? natura { get; set; }

    public bool? enviar { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? grupo { get; set; }

    [StringLength(100)]
    public string? Empresa { get; set; }
}
