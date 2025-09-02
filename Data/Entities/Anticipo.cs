using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Anticipo")]
public partial class Anticipo
{
    [Key]
    public int idAnticipo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroDo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Pedido { get; set; }

    public int? idCliente { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaActual { get; set; }

    public int? idMoneda { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Tasa { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Trm { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorFob { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorFlete { get; set; }

    public bool? TipoSeguro { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PorcentajeSeguro { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorSeguro { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorOtrosGastos { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorCif { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorAjuste { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorCifCop { get; set; }

    public int? Via { get; set; }

    public int? idPuerto { get; set; }

    public int? TipoCarga { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaEstimadaLlegada { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaEstimadaRetiro { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Volumen { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PesoNeto { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PesoBruto { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Gravamen { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Iva { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Salvaguardia { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Compensatorios { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AntiDumping { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Sancion { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Rescate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalImpuestos { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAnticipo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TipoAnticipo { get; set; }

    public int? idUsuario { get; set; }

    [Unicode(false)]
    public string? Observaciones { get; set; }

    [InverseProperty("idAnticipoNavigation")]
    public virtual ICollection<ContenedorAnticipo> ContenedorAnticipos { get; set; } = new List<ContenedorAnticipo>();

    [InverseProperty("idAnticipoNavigation")]
    public virtual ICollection<DetalleReciboCajaAnticipo> DetalleReciboCajaAnticipos { get; set; } = new List<DetalleReciboCajaAnticipo>();

    [InverseProperty("idAnticipoNavigation")]
    public virtual ICollection<GastoAnticipo> GastoAnticipos { get; set; } = new List<GastoAnticipo>();

    [InverseProperty("idAnticipoNavigation")]
    public virtual ICollection<GastoPropioAdicionalAnticipo> GastoPropioAdicionalAnticipos { get; set; } = new List<GastoPropioAdicionalAnticipo>();

    [InverseProperty("idAnticipoNavigation")]
    public virtual ICollection<GastoPropioAnticipo> GastoPropioAnticipos { get; set; } = new List<GastoPropioAnticipo>();

    [InverseProperty("idAnticipoNavigation")]
    public virtual ICollection<ProcesoGastoAnticipo> ProcesoGastoAnticipos { get; set; } = new List<ProcesoGastoAnticipo>();

    [ForeignKey("TipoCarga")]
    [InverseProperty("Anticipos")]
    public virtual tipocarga? TipoCargaNavigation { get; set; }

    [ForeignKey("Via")]
    [InverseProperty("Anticipos")]
    public virtual modotransporte? ViaNavigation { get; set; }

    [ForeignKey("idCliente")]
    [InverseProperty("Anticipos")]
    public virtual exportador? idClienteNavigation { get; set; }

    [ForeignKey("idMoneda")]
    [InverseProperty("Anticipos")]
    public virtual moneda? idMonedaNavigation { get; set; }

    [ForeignKey("idPuerto")]
    [InverseProperty("Anticipos")]
    public virtual lugarembarque? idPuertoNavigation { get; set; }

    [ForeignKey("idUsuario")]
    [InverseProperty("Anticipos")]
    public virtual usuario? idUsuarioNavigation { get; set; }
}
