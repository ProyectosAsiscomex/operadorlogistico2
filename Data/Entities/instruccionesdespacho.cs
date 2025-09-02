using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class instruccionesdespacho
{
    [Key]
    public int idinstrucciondespacho { get; set; }

    public int? idinstrucciones { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidaddespachos { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidaddespachada { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidadpendiente { get; set; }

    [StringLength(50)]
    public string? placa { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobruto { get; set; }

    [StringLength(50)]
    public string? remesa { get; set; }

    [StringLength(250)]
    public string? flotatercero { get; set; }

    [StringLength(15)]
    public string? idinstruccionesdetalle { get; set; }

    [StringLength(1000)]
    public string? lugardevolucion { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? idciudad { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadespacho { get; set; }

    [StringLength(50)]
    public string? remesa2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? estado { get; set; }
}
