using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RegistroImportacion")]
public partial class RegistroImportacion
{
    [Key]
    public int idRegistroImportacion { get; set; }

    [StringLength(50)]
    public string? nroformulario { get; set; }

    [StringLength(100)]
    public string? auxiliar { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaauxiliar { get; set; }

    [StringLength(300)]
    public string? factura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactura { get; set; }

    public int? idexportador { get; set; }

    public int? idEntidadImporta { get; set; }

    public int? idsia { get; set; }

    public int? iddireccionterritorial { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? clasesolicitud { get; set; }

    [StringLength(1000)]
    public string? formulariosanexos { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? actividadimpo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? regimen { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroProgramaPV { get; set; }

    public int? idproveedor { get; set; }

    [StringLength(300)]
    public string? consignatario { get; set; }

    public int? idaduana { get; set; }

    public int? idpais { get; set; }

    public int? idpaiscompra { get; set; }

    public int? idpuertoembarque { get; set; }

    public int? idvia { get; set; }

    [StringLength(500)]
    public string? idreembolso { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? timporeembolsoenmeses { get; set; }

    public int? idmoneda { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? tasa { get; set; }

    [Column(TypeName = "money")]
    public decimal? valtotalmonneg { get; set; }

    [Column(TypeName = "money")]
    public decimal? valtotalendolares { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? valtotalenletras { get; set; }

    [Unicode(false)]
    public string? soliespeciales { get; set; }

    [StringLength(200)]
    public string? personafirmante { get; set; }

    public int? idDoImpo { get; set; }

    public int? cmbidpais { get; set; }

    public int? idincoterm { get; set; }

    [StringLength(200)]
    public string? estadomerca { get; set; }

    public bool? reembolsable { get; set; }

    public int? idcausal { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? descripcioncausal { get; set; }

    public bool? Exencion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DescripciónExencion { get; set; }

    public bool? ExclusionIVA { get; set; }

    public bool? IniciacionRegimen { get; set; }

    public bool? FinalizacionRegimen { get; set; }

    public bool? Legalización { get; set; }

    public bool? PreferenciaArancelaria { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombrepreferenciaArancelaria { get; set; }

    public bool? Otra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DescripcionOtra { get; set; }
}
