using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ReciboCajaMenor")]
public partial class ReciboCajaMenor
{
    [Key]
    public int idReciboCajaMenor { get; set; }

    public int? idCiudad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    public int? idCliente { get; set; }

    public int? idTercero { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    public bool? Anulado { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? MotivoAnulacion { get; set; }

    public int? idUsuario { get; set; }

    public int? idDo { get; set; }

    public bool? arqueada { get; set; }

    public int? idArqueo { get; set; }

    public int? sindo { get; set; }

    public int? idcausacion { get; set; }

    [InverseProperty("idReciboCajaMenorNavigation")]
    public virtual ICollection<DetalleReciboCajaMenor> DetalleReciboCajaMenors { get; set; } = new List<DetalleReciboCajaMenor>();

    [ForeignKey("idCiudad")]
    [InverseProperty("ReciboCajaMenors")]
    public virtual LugarIngresoMercancia? idCiudadNavigation { get; set; }

    [ForeignKey("idCliente")]
    [InverseProperty("ReciboCajaMenors")]
    public virtual exportador? idClienteNavigation { get; set; }

    [ForeignKey("idDo")]
    [InverseProperty("ReciboCajaMenors")]
    public virtual DO? idDoNavigation { get; set; }

    [ForeignKey("idTercero")]
    [InverseProperty("ReciboCajaMenors")]
    public virtual Tercero? idTerceroNavigation { get; set; }

    [ForeignKey("idUsuario")]
    [InverseProperty("ReciboCajaMenors")]
    public virtual usuario? idUsuarioNavigation { get; set; }
}
