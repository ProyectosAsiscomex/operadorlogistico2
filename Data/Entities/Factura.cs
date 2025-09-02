using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Factura
{
    [Key]
    public int idfactura { get; set; }

    public int? iddo { get; set; }

    [StringLength(50)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechavence { get; set; }

    public int? idcliente { get; set; }

    public int? idimportador { get; set; }

    public string? concepto { get; set; }

    public string? anexo { get; set; }

    [Column(TypeName = "money")]
    public decimal? terceros { get; set; }

    [Column(TypeName = "money")]
    public decimal? propios { get; set; }

    [Column(TypeName = "money")]
    public decimal? iva16 { get; set; }

    [Column(TypeName = "money")]
    public decimal? anticipos { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteiva15 { get; set; }

    [Column(TypeName = "money")]
    public decimal? retefuente11 { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteica { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? estado { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? pedido { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? guiabl { get; set; }

    [Column(TypeName = "money")]
    public decimal? valoraduanas { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? tasacambio { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? factorotramoneda { get; set; }

    [Column(TypeName = "money")]
    public decimal? valoraduanasusd { get; set; }

    [Unicode(false)]
    public string? nota { get; set; }

    public long? sindo { get; set; }

    [Column(TypeName = "money")]
    public decimal? retefuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteiva { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValortotalFact { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorneto { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? estadoactual { get; set; }

    public bool? pagada { get; set; }

    public int? idusuario { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechacreacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechamodificacion { get; set; }

    public bool? anulada { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaanulacion { get; set; }

    public int? idusuarioanula { get; set; }

    public string? motivoanulacion { get; set; }

    public bool? revisada { get; set; }

    public bool? control { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? motivoretiro { get; set; }

    public bool? excluircartera { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Contenedores { get; set; }

    public bool? im { get; set; }

    public bool? ia { get; set; }

    public bool? ai { get; set; }

    public bool? ae { get; set; }

    public bool? em { get; set; }

    public bool? ea { get; set; }

    public bool? tn { get; set; }

    public bool? tm { get; set; }

    public bool? os { get; set; }

    public bool? costofinanciero { get; set; }

    public bool? inn { get; set; }

    public bool? sincronizada { get; set; }

    public bool? imprimir { get; set; }

    public int? idusuarioimprime { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaimprime { get; set; }

    [InverseProperty("idFacturaNavigation")]
    public virtual ICollection<FacturaReciboCaja> FacturaReciboCajas { get; set; } = new List<FacturaReciboCaja>();
}
