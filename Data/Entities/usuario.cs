using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class usuario
{
    [Key]
    public int idusuario { get; set; }

    [StringLength(200)]
    public string? primernombre { get; set; }

    [StringLength(200)]
    public string? segundonombre { get; set; }

    [StringLength(200)]
    public string? primerapellido { get; set; }

    [StringLength(200)]
    public string? segundoapellido { get; set; }

    [StringLength(20)]
    public string? identificacion { get; set; }

    [StringLength(100)]
    public string? email { get; set; }

    [Column("usuario")]
    [StringLength(20)]
    public string? usuario1 { get; set; }

    [StringLength(20)]
    public string? clave { get; set; }

    public int? idexportador { get; set; }

    public bool? admin { get; set; }

    public bool? operativo { get; set; }

    public bool? cliente { get; set; }

    [StringLength(100)]
    public string? tema { get; set; }

    [StringLength(50)]
    public string? cedula { get; set; }

    public bool? Digitador { get; set; }

    public bool? Revisor { get; set; }

    public bool? DigitadorRevisor { get; set; }

    [StringLength(500)]
    public string? rutafoto { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ultimasincronizacion { get; set; }

    public short? itinerancia { get; set; }

    public short? tipoenvio { get; set; }

    public bool? enviocorreo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? usuarios { get; set; }

    public bool? contenedores { get; set; }

    public bool? Importacion_Aduanas { get; set; }

    public bool? Exportacion_Aduanas { get; set; }

    public bool? trafico { get; set; }

    public bool? inventario { get; set; }

    public bool? logistica_Impo { get; set; }

    public bool? logistica_Expo { get; set; }

    public bool? fletes { get; set; }

    public bool? planvallejo { get; set; }

    public int? idsucursal { get; set; }

    public bool? archivo { get; set; }

    public bool? admincontabilidad { get; set; }

    public bool? Activo { get; set; }

    public bool? cambiarcontrasena { get; set; }

    public bool? comercial { get; set; }

    [Unicode(false)]
    public string? Telefono { get; set; }

    [Unicode(false)]
    public string? Cargo { get; set; }

    [InverseProperty("idUsuarioNavigation")]
    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    [InverseProperty("Comercial")]
    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();

    [InverseProperty("idAsesorNavigation")]
    public virtual ICollection<ListaChequeoEncabezado> ListaChequeoEncabezadoidAsesorNavigations { get; set; } = new List<ListaChequeoEncabezado>();

    [InverseProperty("idAuxiliarNavigation")]
    public virtual ICollection<ListaChequeoEncabezado> ListaChequeoEncabezadoidAuxiliarNavigations { get; set; } = new List<ListaChequeoEncabezado>();

    [InverseProperty("idUsuarioNavigation")]
    public virtual ICollection<ReciboCajaMenor> ReciboCajaMenors { get; set; } = new List<ReciboCajaMenor>();

    [InverseProperty("idUsuarioNavigation")]
    public virtual ICollection<UsuarioSigloXXI> UsuarioSigloXXIs { get; set; } = new List<UsuarioSigloXXI>();

    [InverseProperty("idUsuarioNavigation")]
    public virtual ICollection<causacionesencabezado> causacionesencabezados { get; set; } = new List<causacionesencabezado>();
}
