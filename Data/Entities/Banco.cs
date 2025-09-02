using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Banco
{
    [Key]
    public int idBanco { get; set; }

    public int? idPais { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Identificacion { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? NroCuenta { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Ciudad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoBancoRepublica { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroCheque { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cuentacont { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? com_che_ge { get; set; }

    public bool? CuentaPrincipal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CuentaTipo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NombreCuenta { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? codigo_ach { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nro_transf { get; set; }

    public bool? vuce { get; set; }

    public int? idCiudad { get; set; }

    public int? ConsecutivoChequeDesde { get; set; }

    public int? ConsecutivoChequeHasta { get; set; }

    [InverseProperty("idBancoNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipoidBancoNavigations { get; set; } = new List<ReciboCajaAnticipo>();

    [InverseProperty("idBancoTrasladoNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipoidBancoTrasladoNavigations { get; set; } = new List<ReciboCajaAnticipo>();

    [InverseProperty("idBancoNavigation")]
    public virtual ICollection<causacionesencabezado> causacionesencabezados { get; set; } = new List<causacionesencabezado>();

    [ForeignKey("idPais")]
    [InverseProperty("Bancos")]
    public virtual paise? idPaisNavigation { get; set; }
}
